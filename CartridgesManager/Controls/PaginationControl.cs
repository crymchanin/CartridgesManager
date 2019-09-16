using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class PaginationControl : UserControl {

        private const int NAVIGATION_PANEL_MINIMUM_HEIGHT = 150;

        private CodeButtonCollection _buttons;


        public PaginationControl() {
            InitializeComponent();

            NavPanel.Height = NAVIGATION_PANEL_MINIMUM_HEIGHT;

            BackwardButton.Barcode = BackwardButton.RegisterControl((s) => { });
            ForwardButton.Barcode = ForwardButton.RegisterControl((s) => { });
            CloseButton.Barcode = CloseButton.RegisterControl((s) => { });


        }

        public int NavigationPanelHeight {
            get {
                return NavPanel.Height;
            }
            set {
                int newVal = Math.Max(NAVIGATION_PANEL_MINIMUM_HEIGHT, value);
                NavPanel.Height = newVal;
            }
        }

        public int CurrentPageIndex { get; set; }

        public CodeButtonCollection Buttons {
            get {
                return _buttons;
            }
            set {
                _buttons = value;
            }
        }

        public void ShowPageContent() {

        }
    }
}
