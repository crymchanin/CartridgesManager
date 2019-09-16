using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CartridgesManager.Controls {
    public class QRButton : BaseCodeButton, ICodeButton {
        string ICodeButton.Barcode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        event EventHandler ICodeButton.ButtonClick {
            add {
                throw new NotImplementedException();
            }

            remove {
                throw new NotImplementedException();
            }
        }

        T ICodeButton.GetCustomData<T>() {
            throw new NotImplementedException();
        }

        void ICodeButton.SetCustomData<T>(T customData) {
            throw new NotImplementedException();
        }
    }
}
