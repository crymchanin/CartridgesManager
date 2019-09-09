using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class BarcodeBox : UserControl {

        /// <summary>
        /// Представляет метод, обрабатывающий событие BarcodeEndRead
        /// </summary>
        /// <param name="barcode">Штрихкод</param>
        public delegate void BarcodeEndReadEventHandler(long barcode);

        /// <summary>
        /// Происходит завершении чтения штрихкода
        /// </summary>
        public event BarcodeEndReadEventHandler BarcodeEndRead;

        /// <summary>
        /// Конструктор
        /// </summary>
        public BarcodeBox() {
            InitializeComponent();
        }

        /// <summary>
        /// Штрихкод
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public long Barcode {
            get {
                string brcStr = (BarcodeTextBox.Text.Length == 14) ? BarcodeTextBox.Text : "";
                long brc;
                if (!long.TryParse(brcStr, out brc)) {
                    brc = 0;
                }
                return brc;
            }
            set {
                BarcodeTextBox.Text = value.ToString();
            }
        }

        private void BarcodeTextBox_TextChanged(object sender, EventArgs e) {
            if (BarcodeTextBox.Text.Length == 14) {
                BarcodeEndRead?.Invoke(Barcode);
                BarcodeTextBox.SelectAll();
            }
        }
    }
}
