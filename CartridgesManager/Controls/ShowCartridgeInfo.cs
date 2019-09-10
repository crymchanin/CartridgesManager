using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class ShowCartridgeInfo : UserControl {

        public ShowCartridgeInfo(long code, CartridgeInfo cartridgeInfo) {
            try {
                InitializeComponent();

                GuiController.IsMainActionsAllowed = false;

                NumberBox.Text = code.ToString();
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

                GuiController.ControlCallback callback = delegate () {
                    CloseTabButton.UnregisterControl();
                    this.NavigateToMainPage();
                };
                CloseTabButton.Barcode = CloseTabButton.RegisterControl(callback);
                CloseTabButton.ButtonClick += delegate (object s, EventArgs e) {
                    callback.Invoke();
                };
            }
            catch (Exception ex) {
                GuiController.IsMainActionsAllowed = true;
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
