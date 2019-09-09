using System.ComponentModel;
using System.Windows.Forms;


namespace CartridgesManager {
    public class BarcodeForm : Form {

        private const int BarcodeLength = 14;
        private string BarcodeString = string.Empty;

        /// <summary>
        /// Представляет метод, обрабатывающий событие BarcodeReaded
        /// </summary>
        /// <param name="barcode">Штрихкод</param>
        public delegate void BarcodeReadedEventHandler(string code);

        /// <summary>
        /// Происходит завершении чтения штрихкода
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event BarcodeReadedEventHandler BarcodeReaded;


        public BarcodeForm() : base() {
            KeyPress += BarcodeForm_KeyPress;
        }

        private void BarcodeForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (BarcodeString.Length >= BarcodeLength) {
                BarcodeString = string.Empty;
            }

            BarcodeString += e.KeyChar;
            if (BarcodeString.Length == BarcodeLength) {
                BarcodeReaded?.Invoke(BarcodeString);
            }
        }
    }
}
