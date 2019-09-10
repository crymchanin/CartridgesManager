using CartridgesManager.Controls;
using Feodosiya.Lib.Threading;
using System;
using System.Windows.Forms;


namespace CartridgesManager {

    public partial class MainForm : BarcodeForm {

        private System.Threading.Timer ClockTimer;


        public MainForm() {
            InitializeComponent();

            GuiController.MainForm = this;

            if (AppHelper.Configuration.RunInFullScreen) {
                this.SwitchFullScreenMode();
            }

            try {
                ClockTimer = new System.Threading.Timer(delegate (object s) {
                    try {
                        MainStrip.InvokeIfRequired(() => TimeStripLabel.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                    }
                    catch { }
                }, null, 0, 300);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            string strCode = "90000000000001";

            if (strCode.Length == 14) {
                //BarcodeTextBox.SelectAll();

                try {
                    long code = long.Parse(strCode);
                    if (ActionsHelper.IsServiceCode(code)) {
                        switch (code) {
                            case (long)ActionsHelper.MainActions.CartridgeInfo:
                                CartridgeInfo cartridgeInfo = DatabaseHelper.GetCartridgeInfo(long.Parse("29810021067228"));
                                ShowCartridgeInfo ctrl = new ShowCartridgeInfo(long.Parse("29810021067228"), cartridgeInfo);
                                ctrl.Dock = DockStyle.Fill;
                                Controls.Add(ctrl);
                                ctrl.BringToFront();
                                break;
                            case (long)ActionsHelper.MainActions.AddNewCartridge:
                                break;
                            case (long)ActionsHelper.MainActions.ServiceCartridge:
                                break;
                            case (long)ActionsHelper.MainActions.PostOfficeInfo:
                                break;
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void MainForm_BarcodeReaded(string code) {
            try {
                long lCode = long.Parse(code);
                if (ActionsHelper.IsServiceCode(lCode) && GuiController.IsMainActionsAllowed) {
                    switch (lCode) {
                        case (long)ActionsHelper.MainActions.NewSession:
                            UserSelect ctrl = new UserSelect();
                            ctrl.Dock = DockStyle.Fill;
                            Controls.Add(ctrl);
                            ctrl.BringToFront();
                            break;
                        case (long)ActionsHelper.MainActions.CloseSession:
                            break;
                        case (long)ActionsHelper.MainActions.CartridgeInfo:
                            mainControl1.ShowBarcodeBox(true);
                            break;
                        case (long)ActionsHelper.MainActions.AddNewCartridge:
                            break;
                        case (long)ActionsHelper.MainActions.ServiceCartridge:
                            break;
                        case (long)ActionsHelper.MainActions.PostOfficeInfo:
                            break;
                        case (long)ActionsHelper.MainActions.FullScreen:
                            this.SwitchFullScreenMode();
                            break;
                        case (long)ActionsHelper.MainActions.ExitApplication:
                            GuiController.ExitApplication();
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
