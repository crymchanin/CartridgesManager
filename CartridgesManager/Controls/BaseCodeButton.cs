using System;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public abstract class BaseCodeButton : Button, ICodeButton {

        protected BaseCodeButton() {
            Disposed += BaseCodeButton_Disposed;
        }

        public abstract string Barcode { get; set; }

        public abstract CodeButtonType BarcodeType { get; }

        public abstract T GetCustomData<T>();

        public abstract void SetCustomData<T>(T customData);

        internal void BaseCodeButton_Disposed(object sender, EventArgs e) {
            throw new NotImplementedException();
            //this.UnregisterControl();
        }
    }
}
