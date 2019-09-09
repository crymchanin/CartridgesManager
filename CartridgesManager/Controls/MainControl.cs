using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;


namespace CartridgesManager.Controls {
    public partial class MainControl : UserControl {

        public MainControl() {
            InitializeComponent();

            NewSessionButton.Barcode = ((long)ActionsHelper.MainActions.NewSession).ToString();
            NewSessionButton.ButtonClick += delegate (object s, EventArgs e) {
                // Открытие смены здесь
            };
            ServiceButton.Barcode = ((long)ActionsHelper.MainActions.ServiceCartridge).ToString();
            ServiceButton.ButtonClick += delegate (object s, EventArgs e) {
                // Обслуживание картриджа здесь
            };
            AddNewCartridgeButton.Barcode = ((long)ActionsHelper.MainActions.AddNewCartridge).ToString();
            AddNewCartridgeButton.ButtonClick += delegate (object s, EventArgs e) {
                // Добавление нового картриджа здесь
            };
            ViewInfoButton.Barcode = ((long)ActionsHelper.MainActions.CartridgeInfo).ToString();
            ViewInfoButton.ButtonClick += delegate (object s, EventArgs e) {
                ShowBarcodeBox(true);
            };
            ViewCartridgesButton.Barcode = ((long)ActionsHelper.MainActions.PostOfficeInfo).ToString();
            ViewCartridgesButton.ButtonClick += delegate (object s, EventArgs e) {
                // Просмотр картриджей отделения здесь
            };
            CloseSessionButton.Barcode = ((long)ActionsHelper.MainActions.CloseSession).ToString();
            CloseSessionButton.ButtonClick += delegate (object s, EventArgs e) {
                // Закрытие смены здесь
            };
            FullScreenButton.Barcode = ((long)ActionsHelper.MainActions.FullScreen).ToString();
            FullScreenButton.ButtonClick += delegate (object s, EventArgs e) {
                ((MainForm)Parent).SwitchFullScreenMode();
            };
            ExitButton.Barcode = ((long)ActionsHelper.MainActions.ExitApplication).ToString();
            ExitButton.ButtonClick += delegate (object s, EventArgs e) {
                ActionsHelper.ExitApplication();
            };

            MainBarcodeBox.BarcodeEndRead += BarcodeBox1_BarcodeEndRead;
        }

        /// <summary>
        /// Отображает поле для считывания кода картриджа
        /// </summary>
        /// <param name="showBox">Если true будет поле отображено</param>
        public void ShowBarcodeBox(bool showBox) {
            MainBarcodeBox.Visible = showBox;
            if (showBox) {
                MainBarcodeBox.Focus();
            }
        }

        private void BarcodeBox1_BarcodeEndRead(long barcode) {
            CartridgeInfo cartridgeInfo = DatabaseHelper.GetCartridgeInfo(barcode);
            ShowCartridgeInfo ctrl = new ShowCartridgeInfo(barcode, cartridgeInfo);
            ctrl.Dock = DockStyle.Fill;
            Parent.Controls.Add(ctrl);
            ctrl.BringToFront();
            ShowBarcodeBox(false);
        }
    }
}
