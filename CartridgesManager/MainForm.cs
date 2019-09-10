using Feodosiya.Lib.Threading;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace CartridgesManager {

    public partial class MainForm : Form {

        private System.Threading.Timer ClockTimer;


        public MainForm() {
            InitializeComponent();

            GuiController.MainForm = this;

            try {
                // Запускаем таймер для отображения часов
                ClockTimer = new System.Threading.Timer(delegate (object s) {
                    try {
                        MainStrip.InvokeIfRequired(() => TimeStripLabel.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                    }
                    catch { }
                }, null, 0, 300);

                if (AppHelper.Configuration.RunInFullScreen) {
                    this.SwitchFullScreenMode();
                }

                // Начинаем прослушивать COM порт
                AppHelper.ComListener = new ComListener(AppHelper.Configuration.BarcodeScanner.ComPort,
                    AppHelper.Configuration.BarcodeScanner.BaudRate);
                AppHelper.ComListener.BarcodeReaded += BarcodeReaded;
                AppHelper.ComListener.Listen();

                // Если смена была ранее открыта, то возобновляем её
                if (!string.IsNullOrEmpty(AppHelper.Configuration.SessionUserName)) {
                    if (!SessionManager.CreateNewSession(AppHelper.Configuration.SessionUserName)) {
                        GuiController.CreateMessage("Не удалось возобновить смену. Проверьте конфигурационный файл", true);
                    }
                    else {
                        GuiController.CreateMessage("Возобновлена смена под пользователем " + SessionManager.WorkerName, false);
                    }
                }

                /*PrivateFontCollection fontCollection = new PrivateFontCollection();
                fontCollection.AddFontFile(@".\Fonts\Century-Gothic.ttf");
                FontFamily fontFamily = new FontFamily("Century Gothic", fontCollection);
                Font = new Font(fontFamily, 8);*/
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Load += (s, e) => GuiController.ExitApplication();
            }
        }

        private void BarcodeReaded(string code) {
            try {
                GuiController.CreateMessage("", false);

                long lCode = long.Parse(code);
                if (ActionsHelper.IsServiceCode(lCode) && GuiController.IsMainActionsAllowed) {
                    switch (lCode) {
                        case (long)ActionsHelper.MainActions.NewSession:
                            GuiController.InvokeAssociatedCallback(code);
                            break;
                        case (long)ActionsHelper.MainActions.CloseSession:
                            GuiController.InvokeAssociatedCallback(code);
                            break;
                        case (long)ActionsHelper.MainActions.CartridgeInfo:
                            mainControl1.ShowBarcodeBox(true); // !!!!!
                            break;
                        case (long)ActionsHelper.MainActions.AddNewCartridge:
                            break;
                        case (long)ActionsHelper.MainActions.ServiceCartridge:
                            break;
                        case (long)ActionsHelper.MainActions.PostOfficeInfo:
                            break;
                        case (long)ActionsHelper.MainActions.FullScreen:
                            GuiController.InvokeAssociatedCallback(code);
                            break;
                        case (long)ActionsHelper.MainActions.ExitApplication:
                            GuiController.InvokeAssociatedCallback(code);
                            break;
                        default:
                            break;
                    }
                }
                else {
                    if (lCode >= GuiController.START_RANGE && lCode <= GuiController.END_RANGE) {
                        GuiController.InvokeAssociatedCallback(code);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
