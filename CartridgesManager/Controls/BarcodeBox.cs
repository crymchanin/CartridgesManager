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
        /// Представляет метод, обрабатывающий событие BarcodeBoxLostFocus
        /// </summary>
        public delegate void BarcodeBoxLostFocusEventHandler();

        /// <summary>
        /// Происходит при потере фокуса элементом управления
        /// </summary>
        public event BarcodeBoxLostFocusEventHandler BarcodeBoxLostFocus;

        /// <summary>
        /// Представляет метод, обрабатывающий событие BarcodeBoxGotFocus
        /// </summary>
        public delegate void BarcodeBoxGotFocusEventHandler();

        /// <summary>
        /// Вызывается при получении фокуса элементом управления.
        /// </summary>
        public event BarcodeBoxGotFocusEventHandler BarcodeBoxGotFocus;


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
            if (BarcodeTextBox.Text.Length == 14 && Visible) {
                BarcodeEndRead?.Invoke(Barcode);
                BarcodeTextBox.SelectAll();
            }
        }

        private void BarcodeTextBox_Leave(object sender, EventArgs e) {
            BarcodeBoxLostFocus?.Invoke();
            if (Visible) {
                BarcodeTextBox.Focus();
            }
        }

        private void BarcodeTextBox_Enter(object sender, EventArgs e) {
            BarcodeBoxGotFocus?.Invoke();
        }
    }
}
