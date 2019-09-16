using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public abstract class BaseCodeButton : Control, ICodeButton {

        /// <summary>
        /// Происходит завершении чтения штрихкода
        /// </summary>
        event EventHandler ButtonClick;


         protected BaseCodeButton() {
            Disposed += BaseCodeButton_Disposed;
        }

        public string Barcode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CodeButtonType BarcodeType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract T GetCustomData<T>();

        public abstract void SetCustomData<T>(T customData);

        private void BaseCodeButton_Disposed(object sender, EventArgs e) {
            throw new NotImplementedException();
            //this.UnregisterControl();
        }
    }
}
