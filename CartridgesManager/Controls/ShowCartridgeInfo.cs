using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class ShowCartridgeInfo : UserControl {

        public ShowCartridgeInfo() {
            try {
                InitializeComponent();

                GuiController.IsMainActionsAllowed = false;

                CloseTabButton.Barcode = CloseTabButton.RegisterControl((c) => this.NavigateToMainPage());

                Disposed += (s, e) => AppHelper.ComListener.BarcodeReaded -= CartridgeCodeReaded;
                AppHelper.ComListener.BarcodeReaded += CartridgeCodeReaded;
            }
            catch (Exception ex) {
                GuiController.IsMainActionsAllowed = true;
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CartridgeCodeReaded(string code) {
            try {
                if (NumberBox.Focused) {
                    NumberBox.Text = code;
                    NumberBox.SelectionStart = NumberBox.Text.Length;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCartridgeInformation(string code) {

            CartridgeInfo cartridgeInfo = DatabaseHelper.GetCartridgeInfo(code);
            if (cartridgeInfo == null) {
                GuiController.CreateMessage("Картридж с таким номером не найден", true);
                return;
            }
            ModelBox.Text = cartridgeInfo.ModelName;
            LocationBox.Text = cartridgeInfo.Location;
            InitiatorBox.Text = cartridgeInfo.InitiatorLastName;
            DataBox.Text = cartridgeInfo.TransferDate.ToString("dd.MM.yyyy");
            StateBox.Text = cartridgeInfo.State;

            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ServiceOperation operation in cartridgeInfo.Operations) {
                ListViewItem item = new ListViewItem(operation.OperationDate.ToString("dd.MM.yyyy"));
                item.SubItems.Add(operation.OperationType);
                item.SubItems.Add(operation.PartName);
                item.SubItems.Add(operation.PartsCount.ToString());
                item.SubItems.Add(operation.WorkerLastName);
                item.SubItems.Add(operation.Comment);
                items.Add(item);
            }
            OpertionsBox.Items.AddRange(items.ToArray());
        }

        private void NumberBox_TextChanged(object sender, EventArgs e) {
            try {
                if (NumberBox.Text.Length == 14) {
                    ShowCartridgeInformation(NumberBox.Text);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
