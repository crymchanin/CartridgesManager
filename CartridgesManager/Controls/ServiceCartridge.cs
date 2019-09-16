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
    public partial class ServiceCartridge : UserControl {

        private const int ContentMargins = 15;
        private const int ContentWidth = 207;

        public ServiceCartridge() {
            InitializeComponent();

            CloseTabButton.Barcode = CloseTabButton.RegisterControl((c) => this.NavigateToMainPage());

            DateBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            WorkerBox.Text = SessionManager.WorkerName;

            GuiController.ControlCallback SessionCallback = delegate (string code) {
                BarcodeButton sender = GuiController.GetAssociatedControl(code);
                sender.ButtonChecked = !sender.ButtonChecked;
            };

            string[] actions = DatabaseHelper.GetCartridgeActionTypes().ToArray(); // !!!!!
            List<BarcodeButton> buttons = new List<BarcodeButton>();
            int index = 0;
            foreach (string action in actions) {
                BarcodeButton button = new BarcodeButton();
                button.ButtonText = action;
                button.Barcode = button.RegisterControl(SessionCallback);
                button.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                button.CompactMode = true;
                button.TabIndex = index;
                button.Margin = new Padding(0, 0, ContentMargins, ContentMargins);
                //button.SetCustomData(type);

                buttons.Add(button);
                index++;
            }
            ContentLayoutPanel.Controls.AddRange(buttons.ToArray());
        }
    }
}
