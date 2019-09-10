using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Threading.Tasks;

namespace CartridgesManager {
    /// <summary>
    /// Класс для работы с COM портом
    /// </summary>
    public class ComListener {

        private const int BARCODE_LENGTH = 14;
        private SerialPort SerialPort;

        /// <summary>
        /// Представляет метод, обрабатывающий событие BarcodeReaded
        /// </summary>
        /// <param name="barcode"></param>
        public delegate void BarcodeReadedEventHandler(string barcode);

        /// <summary>
        /// Происходит завершении чтения штрихкода
        /// </summary>
        public event BarcodeReadedEventHandler BarcodeReaded;


        /// <summary>
        /// Создает новый экземпляр класса ComListener с указанным портом
        /// </summary>
        /// <param name="port"></param>
        public ComListener(string port, int baudRate) {
            SerialPort = new SerialPort(port);
            SerialPort.BaudRate = baudRate;
            SerialPort.DataBits = 8;
            SerialPort.ParityReplace = 63;
            SerialPort.ReadBufferSize = 4096;
            SerialPort.ReadTimeout = -1;
            SerialPort.ReceivedBytesThreshold = 1;
            SerialPort.StopBits = StopBits.One;
            SerialPort.WriteBufferSize = 2048;
            SerialPort.WriteTimeout = -1;
        }

        /// <summary>
        /// Начинает считывание из COM порта
        /// </summary>
        public void Listen() {
            SerialPort.DataReceived += OnDataReceived;
            SerialPort.Open();
        }

        /// <summary>
        /// Завершает считывание из COM порта
        /// </summary>
        public void Close() {
            SerialPort.DataReceived -= OnDataReceived;
            SerialPort.Close();
        }

        private void RaiseEventOnUIThread(Delegate theEvent, object[] args) {
            foreach (Delegate d in theEvent.GetInvocationList()) {
                ISynchronizeInvoke syncer = d.Target as ISynchronizeInvoke;
                if (syncer == null) {
                    d.DynamicInvoke(args);
                }
                else {
                    syncer.BeginInvoke(d, args);
                }
            }
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e) {
            string data = SerialPort.ReadExisting();
            if (data.Length != BARCODE_LENGTH) {
                throw new FormatException("Длина считанного штрихкода не соответствует необходимой: " + BARCODE_LENGTH.ToString());
            }
            RaiseEventOnUIThread(BarcodeReaded, new object[] { data });
        }
    }
}
