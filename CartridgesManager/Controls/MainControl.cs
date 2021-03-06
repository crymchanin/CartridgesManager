﻿using System;
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

            ServiceButton.Barcode = ServiceButton.RegisterControl(((long)ActionsHelper.MainActions.ServiceCartridge),
                delegate (string code) {
                    if (SessionManager.IsSessionCreated) {
                        ServiceCartridge serviceCartridge = new ServiceCartridge();
                        serviceCartridge.ShowThisPage();
                    }
                    else {
                        GuiController.CreateMessage("Смена не открыта", true);
                    }
                });

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

            ViewInfoButton.Barcode = ViewInfoButton.RegisterControl(((long)ActionsHelper.MainActions.CartridgeInfo),
                delegate (string code) {
                    ShowCartridgeInfo showCartridgeInfo = new ShowCartridgeInfo();
                    showCartridgeInfo.ShowThisPage();
                });

            ViewCartridgesButton.Barcode = ((long)ActionsHelper.MainActions.PostOfficeInfo).ToString();
            ViewCartridgesButton.ButtonClick += delegate (ICodeButton s, EventArgs e) {
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
        }
    }
}
