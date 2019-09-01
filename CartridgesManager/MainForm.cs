using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartridgesManager.Controls;
using IronBarCode;


namespace CartridgesManager {

    public partial class MainForm : Form {

        private PrintDocument pd = new PrintDocument();
        public Image BarcodeImage { get; set; }


        public MainForm() {
            InitializeComponent();

            
            pd.PrintPage += delegate(object o, PrintPageEventArgs e) {
                e.Graphics.DrawImage(BarcodeImage, 0 ,0);
            };
        }

        /*
            if (textBox1.Text.Length == 14) {
                GeneratedBarcode bar = BarcodeWriter.CreateBarcode(BarcodeTextBox.Text, BarcodeWriterEncoding.Code39, 5, 40);
                bar.AddAnnotationTextBelowBarcode(textBox2.Text);
                BarcodeImage = bar.Image;
                pictureBox1.Image = BarcodeImage;
                BarcodeImage.Save(textBox2.Text + ".jpg", ImageFormat.Jpeg);
                pd.Print();
            }
         */

        private void textBox1_TextChanged(object sender, EventArgs e) {
            /*string strCode = BarcodeTextBox.Text;

            if (strCode.Length == 14) {
                BarcodeTextBox.SelectAll();

                try {
                    long code = long.Parse(strCode);
                    if (ActionsHelper.IsServiceCode(code)) {
                        switch (code) {
                            case (long)ActionsHelper.MainActions.CartridgeInfo:
                                CartridgeInfo cartridgeInfo = DatabaseHelper.GetCartridgeInfo(long.Parse(textBox2.Text));
                                ShowCartridgeInfo ctrl = new ShowCartridgeInfo(long.Parse(textBox2.Text), cartridgeInfo);
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
            }*/
        }
    }
}
