using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class UserSelect : UserControl {

        private const int ContentMargins = 15;
        private const int ContentWidth = 207;
        private const int ContentHeight = 215;


        public UserSelect() {
            try {
                InitializeComponent();

                GuiController.IsMainActionsAllowed = false;

                CloseTabButton.Barcode = CloseTabButton.RegisterControl((c) => this.NavigateToMainPage());
                GuiController.ControlCallback SessionCallback = delegate (string code) {
                    string workerName = GuiController.GetAssociatedControl(code).ButtonText;
                    if (SessionManager.CreateNewSession(workerName)) {
                        GuiController.CreateMessage("Смена открыта под пользователем " + workerName, false);
                    }
                    else {
                        GuiController.CreateMessage("Не удалось открыть смену. Проверьте конфигурационный файл", true);
                    }
                    this.NavigateToMainPage();
                };

                List<ButtonWithBarcode> buttons = new List<ButtonWithBarcode>();
                int index = 0;
                foreach (string user in AppHelper.Configuration.Users) {
                    ButtonWithBarcode button = new ButtonWithBarcode();
                    button.ButtonText = user;
                    button.ButtonImage = Properties.Resources.sad_64;
                    button.Barcode = button.RegisterControl(SessionCallback);
                    button.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                    button.Height = ContentHeight;
                    button.Width = ContentWidth;
                    button.TabIndex = index;
                    button.Margin = new Padding(ContentMargins, ContentMargins, 0, 0);

                    buttons.Add(button);
                    index++;
                }
                ContentLayoutPanel.Controls.AddRange(buttons.ToArray());
            }
            catch (Exception ex) {
                GuiController.IsMainActionsAllowed = true;
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
