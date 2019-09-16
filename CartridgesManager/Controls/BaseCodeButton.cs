using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CartridgesManager.Controls {
    public abstract class BaseCodeButton : ICodeButton {

        public BaseCodeButton() {
            //Disposed += BaseCodeButton_Disposed;
        }

        public string Barcode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        event EventHandler ICodeButton.ButtonClick {
            add {
                throw new NotImplementedException();
            }

            remove {
                throw new NotImplementedException();
            }
        }

        public T GetCustomData<T>() {
            throw new NotImplementedException();
        }

        public void SetCustomData<T>(T customData) {
            throw new NotImplementedException();
        }

        private void BaseCodeButton_Disposed(object sender, EventArgs e) {
            //this.UnregisterControl();
        }
    }
}
