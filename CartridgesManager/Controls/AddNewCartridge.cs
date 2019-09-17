using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class AddNewCartridge : UserControl {

        private const int ContentMargins = 15;
        private const int ContentWidth = 207;



        private void CartridgeCodeReaded(string code) {
            if (CodeBox.Focused) {
                CodeBox.Text = code;
                SaveButton.Focus();
            }
        }

        public AddNewCartridge() {
            GuiController.IsMainActionsAllowed = false;

            InitializeComponent();

            Disposed += (s, e) => AppHelper.ComListener.BarcodeReaded -= CartridgeCodeReaded;
            AppHelper.ComListener.BarcodeReaded += CartridgeCodeReaded;
            DateBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            WorkerBox.Text = SessionManager.WorkerName;

            CloseTabButton.Barcode = CloseTabButton.RegisterControl((c) => this.NavigateToMainPage());

            SaveButton.Barcode = SaveButton.RegisterControl((c) => this.NavigateToMainPage());

            GuiController.ControlCallback SessionCallback = delegate (string code) {
                ICodeButton sender = GuiController.GetAssociatedControl(code);
                sender.Checked = !sender.Checked;
            };

            string[] types = DatabaseHelper.GetCartridgeTypes().ToArray();
            List<LinearButton> buttons = new List<LinearButton>();
            int index = 0;
            foreach (string type in types) {
                LinearButton button = new LinearButton();
                button.Text = type;
                button.Barcode = button.RegisterControl(SessionCallback);
                button.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                button.CompactMode = true;
                button.TabIndex = index;
                button.Margin = new Padding(0, 0, 0, ContentMargins);
                button.SetCustomData(type);

                buttons.Add(button);
                index++;
            }
            TypeLayoutPanel.Controls.AddRange(buttons.ToArray());

            string[] models = DatabaseHelper.GetCartridgeModels().ToArray();
            buttons = new List<LinearButton>();
            index = 0;
            foreach (string model in models) {
                LinearButton button = new LinearButton();
                button.Text = model;
                button.Barcode = button.RegisterControl(SessionCallback);
                button.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                button.CompactMode = true;
                button.TabIndex = index;
                button.Margin = new Padding(0, 0, ContentMargins, ContentMargins);
                button.SetCustomData(model);

                buttons.Add(button);
                index++;
            }
            ModelsLayoutPanel.Controls.AddRange(buttons.ToArray());

            LocationsBox.LoadContentPage += delegate (AlphabetBox sender, char[] words) {
                string[] locations = DatabaseHelper.GetCartridgeLocations().ToArray();
                locations = locations.Where(x => words.Contains(char.ToLowerInvariant(x.First()))).ToArray();
                buttons = new List<LinearButton>();
                index = 0;
                foreach (string location in locations) {
                    LinearButton button = new LinearButton();
                    button.Text = location;
                    button.Barcode = button.RegisterControl(SessionCallback);
                    button.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                    button.CompactMode = true;
                    button.TabIndex = index;
                    button.Margin = new Padding(0, 0, ContentMargins, ContentMargins);
                    button.SetCustomData(location);

                    buttons.Add(button);
                    index++;
                }
                LinearButton backButton = new LinearButton();
                backButton.Text = "Вернуться назад";
                backButton.Image = Properties.Resources.back_64;
                backButton.Barcode = backButton.RegisterControl((c) => sender.LoadMainPage());
                backButton.BackColor = Color.LightSkyBlue;
                backButton.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                backButton.CompactMode = true;
                backButton.FontSize = 9.25F;
                backButton.TabIndex = index;
                backButton.Margin = new Padding(0, 0, ContentMargins, ContentMargins);
                buttons.Add(backButton);

                sender.ContentControls.AddRange(buttons.ToArray());
            };
        }
    }
}
