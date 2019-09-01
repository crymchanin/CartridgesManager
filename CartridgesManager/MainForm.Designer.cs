namespace CartridgesManager {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.barcodeControl1 = new CartridgesManager.Controls.BarcodeControl();
            this.SuspendLayout();
            // 
            // barcodeControl1
            // 
            this.barcodeControl1.BackColor = System.Drawing.Color.White;
            this.barcodeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeControl1.Location = new System.Drawing.Point(0, 0);
            this.barcodeControl1.Name = "barcodeControl1";
            this.barcodeControl1.Size = new System.Drawing.Size(1204, 702);
            this.barcodeControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 702);
            this.Controls.Add(this.barcodeControl1);
            this.MinimumSize = new System.Drawing.Size(1220, 740);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картриджи";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BarcodeControl barcodeControl1;
    }
}

