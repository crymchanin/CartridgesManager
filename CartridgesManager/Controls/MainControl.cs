using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class MainControl : UserControl {

        public MainControl() {
            InitializeComponent();

            // Открытие смены
            NewSessionButton.Barcode = NewSessionButton.RegisterControl(((long)ActionsHelper.MainActions.NewSession),
                delegate (string code) {
                    if (SessionManager.IsSessionCreated) {
                        GuiController.CreateMessage("Смена уже открыта под пользователем " + SessionManager.WorkerName, true);
                        return;
                    }
                    else {
                        UserSelect userSelect = new UserSelect();
                        userSelect.ShowThisPage();
                    }
                });

            ServiceButton.Barcode = ((long)ActionsHelper.MainActions.ServiceCartridge).ToString();
            ServiceButton.ButtonClick += delegate (object s, EventArgs e) {
                // Обслуживание картриджа здесь
            };

            AddNewCartridgeButton.Barcode = AddNewCartridgeButton.RegisterControl(((long)ActionsHelper.MainActions.AddNewCartridge),
                delegate (string code) {
                    if (SessionManager.IsSessionCreated) {
                        AddNewCartridge addNewCartridge = new AddNewCartridge();
                        addNewCartridge.ShowThisPage();
                    }
                    else {
                        GuiController.CreateMessage("Смена не открыта", true);
                    }
                });

            ViewInfoButton.Barcode = AddNewCartridgeButton.RegisterControl(((long)ActionsHelper.MainActions.CartridgeInfo),
                delegate (string code) {
                    ShowCartridgeInfo showCartridgeInfo = new ShowCartridgeInfo();
                    showCartridgeInfo.ShowThisPage();
                });

            ViewCartridgesButton.Barcode = ((long)ActionsHelper.MainActions.PostOfficeInfo).ToString();
            ViewCartridgesButton.ButtonClick += delegate (object s, EventArgs e) {
                // Просмотр картриджей отделения здесь
            };

            // Закрытие смены
            CloseSessionButton.Barcode = CloseSessionButton.RegisterControl(((long)ActionsHelper.MainActions.CloseSession),
                delegate(string code) {
                    if (SessionManager.IsSessionCreated) {
                        SessionManager.CloseSession();
                        GuiController.CreateMessage("Закрытие смены выполнено", false);
                    }
                    else {
                        GuiController.CreateMessage("Смена не открыта", true);
                    }
                });

            // Переключение полноэкранного режима
            FullScreenButton.Barcode = FullScreenButton.RegisterControl(((long)ActionsHelper.MainActions.FullScreen),
                (c) => GuiController.MainForm.SwitchFullScreenMode());

            // Выход из программы
            ExitButton.Barcode = ExitButton.RegisterControl(((long)ActionsHelper.MainActions.ExitApplication),
                (c) => GuiController.ExitApplication());


            MainBarcodeBox.BarcodeEndRead += BarcodeBox1_BarcodeEndRead;
        }

        // УДАЛИТЬ !!!!!
        private void BarcodeBox1_BarcodeEndRead(long barcode) {

        }
    }
}
