using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;


namespace CartridgesManager {

    /// <summary> 
    /// The configuration section for the barcode scanner listener. 
    /// </summary> 
    public class BarcodeScannerListenerConfigurationSection : ConfigurationSection {
        /// <summary> 
        /// Gets or sets the list of hardware IDs to listen to as barcode scanners. 
        /// </summary> 
        [ConfigurationProperty("hardwareIds", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(BarcodeScannerListenerConfigurationElementCollection))]
        [SuppressMessage(
            "Microsoft.Usage",
            "CA2227",
            Justification = "The setter is required for the configuration classes to deserialize.")]
        public BarcodeScannerListenerConfigurationElementCollection HardwareIds {
            get { return this["hardwareIds"] as BarcodeScannerListenerConfigurationElementCollection; }
            set { this["hardwareIds"] = value; }
        }

        /// <summary> 
        /// Gets the configuration section. 
        /// </summary> 
        /// <exception cref="ConfigurationErrorsException">if the configuration is malformed</exception> 
        /// <returns>the configuration section</returns> 
        [SuppressMessage(
            "Microsoft.Design",
            "CA1024",
            Justification = "The method call conveys that this is an expensive operation that may fail.")]
        public static BarcodeScannerListenerConfigurationSection GetConfiguration() {
            return ConfigurationManager.GetSection("barcodeScanner") as
                BarcodeScannerListenerConfigurationSection;
        }
    }

    public class BarcodeScannerListener : NativeWindow {

        private Dictionary<IntPtr, BarcodeScannerDeviceInfo> devices = new Dictionary<IntPtr, BarcodeScannerDeviceInfo>();
        private StringBuilder keystrokeBuffer = new StringBuilder();

        public class BarcodeScannerDeviceInfo {

        }

        public BarcodeScannerListener(Form form) {
            if (form == null) {
                throw new ArgumentNullException("Параметр form имеет нулевое значение");
            }

            IntPtr hWnd = form.Handle;
            HookRawInput(hWnd);
            HookHandleEvents(form);
            AssignHandle(hWnd);
        }

        private void HookHandleEvents(Form form) {
            form.HandleCreated += OnHandleCreated;
            form.HandleDestroyed += OnHandleDestroyed;
        }

        private void OnHandleDestroyed(object sender, EventArgs e) {
            AssignHandle(((Form)sender).Handle);
        }

        private void OnHandleCreated(object sender, EventArgs e) {
            ReleaseHandle();
        }

        private static void HookRawInput(IntPtr hwnd) {
            NativeMethods.RawInputDevice[] rid;

            rid = new NativeMethods.RawInputDevice[1];

            rid[0].UsagePage = (NativeMethods.HIDUsagePage)0x01;  // USB HID Generic Desktop Page
            rid[0].Usage = (NativeMethods.HIDUsage)0x06;          // Keyboard Usage ID
            rid[0].Flags = NativeMethods.RawInputDeviceFlags.InputSink;
            rid[0].WindowHandle = hwnd;

            if (!NativeMethods.RegisterRawInputDevices(rid, rid.Length, Marshal.SizeOf(rid[0]))) {
                InvalidOperationException e = new InvalidOperationException(
                    "The barcode scanner listener could not register for raw input devices.",
                    new Win32Exception());
                throw e;
            }
        }

        private bool ProcessRawInputMessage(IntPtr rawInputHeader) {
            bool handled;
            int size;

            handled = false;
            size = 0;

            // First we call GetRawInputData() to set the value of size, which
            // we will the nuse to allocate the appropriate amount of memory in
            // the buffer.
            if (NativeMethods.GetRawInputData(
                    rawInputHeader,
                    NativeMethods.RawInputCommand.Input,
                    IntPtr.Zero,
                    ref size,
                    Marshal.SizeOf(typeof(NativeMethods.RawInputHeader))) == 0) {
                IntPtr buffer;
                BarcodeScannerDeviceInfo deviceInfo;
                NativeMethods.RawInput raw;

                buffer = Marshal.AllocHGlobal(size);

                try {
                    if (NativeMethods.GetRawInputData(
                            rawInputHeader,
                            NativeMethods.RawInputCommand.Input,
                            buffer,
                            ref size,
                            Marshal.SizeOf(typeof(NativeMethods.RawInputHeader))) == size) {
                        raw = (NativeMethods.RawInput)Marshal.PtrToStructure(buffer, typeof(NativeMethods.RawInput));

                        // This is what filters out for the right device we're looking for.
                        // How'd I get that hDevice magic number? Keep reading.
                        if (devices.TryGetValue(raw.Header.Device, out deviceInfo)) {
                            handled = true;

                            if (raw.Header.Type == NativeMethods.RawInputType.Keyboard) {
                                if (raw.Keyboard.Message == NativeMethods.WindowsMessages.KEYDOWN) {
                                    StringBuilder localBuffer;
                                    byte[] state;

                                    localBuffer = new StringBuilder();
                                    state = new byte[256];

                                    if (NativeMethods.GetKeyboardState(state)) {
                                        if (NativeMethods.ToUnicodeEx(
                                                (uint)raw.Keyboard.VirtualKey,
                                                (uint)raw.Keyboard.MakeCode,
                                                state,
                                                localBuffer,
                                                64,
                                                0,
                                                NativeMethods.GetKeyboardLayout(0)) > 0) {
                                            if (localBuffer.Length == 1 && localBuffer[0] == 0x4) {
                                                FireBarcodeScanned(deviceInfo);
                                            }
                                            else {
                                                keystrokeBuffer.Append(localBuffer.ToString());
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                finally {
                    Marshal.FreeHGlobal(buffer);
                }
            }

            return handled;
        }

        /// <summary>
        /// Fires the barcode scanned event.
        /// </summary>
        /// <param name="deviceInfo">information about the device that generated
        /// the barcode</param>
        private void FireBarcodeScanned(BarcodeScannerDeviceInfo deviceInfo) {
            string barcode;
            EventHandler handler;

            barcode = this.keystrokeBuffer.ToString();

            if (barcode != null && barcode.Length > 0) {
                handler = this.BarcodeScanned;

                keystrokeBuffer = new StringBuilder();

                handler?.Invoke(this, new BarcodeScannedEventArgs(barcode, deviceInfo));
            }
        }

        /// <summary>
        /// Enumerates devices provided by GetRawInputDeviceList. We'll only listen
        /// to these devices.
        /// </summary>
        /// <exception cref="ConfigurationErrorsException">if an error occurs
        /// during configuration</exception>
        private void InitializeBarcodeScannerDeviceHandles() {
            BarcodeScannerListenerConfigurationSection config;
            BarcodeScannerListenerConfigurationElementCollection hardwareIdsConfig;
            List<string> hardwareIds;
            uint numDevices;
            uint size;

            config = BarcodeScannerListenerConfigurationSection.GetConfiguration();
            hardwareIdsConfig = config.HardwareIds;
            hardwareIds = new List<string>();
            numDevices = 0;
            size = (uint)Marshal.SizeOf(typeof(NativeMethods.RAWINPUTDEVICELIST));

            foreach (BarcodeScannerListenerConfigurationElement hardwareId in hardwareIdsConfig) {
                hardwareIds.Add(hardwareId.Id);
            }

            // First, we get the number of raw input devices in the list by passing
            // in IntPtr.Zero. Then we allocate sufficient memory and retrieve the
            // entire list.
            if (NativeMethods.GetRawInputDeviceList(IntPtr.Zero, ref numDevices, size) == 0) {
                IntPtr rawInputDeviceList;

                rawInputDeviceList = Marshal.AllocHGlobal((int)(size * numDevices));
                if (NativeMethods.GetRawInputDeviceList(
                    rawInputDeviceList,
                    ref numDevices,
                    size) != uint.MaxValue) {
                    // Next, we iterate through the list, discarding undesired items
                    // and retrieving further information on the barcode scanner devices
                    for (int i = 0; i < numDevices; ++i) {
                        uint pcbSize;
                        NativeMethods.RAWINPUTDEVICELIST rid;

                        pcbSize = 0;
                        rid = (NativeMethods.RAWINPUTDEVICELIST)Marshal.PtrToStructure(
                            new IntPtr((rawInputDeviceList.ToInt32() + (size * i))),
                            typeof(NativeMethods.RAWINPUTDEVICELIST));

                        if (NativeMethods.GetRawInputDeviceInfo(
                            rid.hDevice,
                            (uint)NativeMethods.RawInputDeviceInfoCommand.RIDI_DEVICENAME,
                            IntPtr.Zero,
                            ref pcbSize) >= 0) {
                            if (pcbSize > 0) {
                                string deviceName;
                                string friendlyName;
                                BarcodeScannerDeviceInfo info;
                                IntPtr data;

                                data = Marshal.AllocHGlobal((int)pcbSize);
                                if (NativeMethods.GetRawInputDeviceInfo(
                                    rid.hDevice,
                                    (uint)NativeMethods.RawInputDeviceInfoCommand.RIDI_DEVICENAME,
                                    data,
                                    ref pcbSize) >= 0) {
                                    deviceName = Marshal.PtrToStringAnsi(data);

                                    if ((from hardwareId in hardwareIds
                                         where deviceName.Contains(hardwareId)
                                         select hardwareId).Count() > 0) {
                                        friendlyName = GetDeviceFriendlyName(deviceName);

                                        info = new BarcodeScannerDeviceInfo(
                                            deviceName,
                                            GetBarcodeScannerDeviceType(rid.Type),
                                            rid.hDevice,
                                            friendlyName);

                                        devices.Add(rid.hDevice, info);
                                    }
                                }

                                Marshal.FreeHGlobal(data);
                            }
                        }
                    }
                }

                Marshal.FreeHGlobal(rawInputDeviceList);
            }
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case (int)NativeMethods.WindowsMessages.INPUT:
                    if (ProcessRawInputMessage(m.LParam)) {
                        // This is the new stuff
                        NativeMethods.MSG message;
                        NativeMethods.PeekMessage(
                            out message,
                            IntPtr.Zero,
                            NativeMethods.WindowsMessages.KEYDOWN,
                            NativeMethods.WindowsMessages.KEYDOWN,
                            NativeMethods.PeekMessageRemoveFlag.PM_REMOVE);
                    }
                    break;
            }

            base.WndProc(ref m);
        }
    }
}
