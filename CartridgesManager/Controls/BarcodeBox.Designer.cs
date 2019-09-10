namespace CartridgesManager.Controls {
    partial class BarcodeBox {
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BarcodeLabel.Location = new System.Drawing.Point(158, 10);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(148, 24);
            this.BarcodeLabel.TabIndex = 1;
            this.BarcodeLabel.Text = "Код картриджа";
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BarcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BarcodeTextBox.Location = new System.Drawing.Point(6, 37);
            this.BarcodeTextBox.MaxLength = 14;
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(438, 29);
            this.BarcodeTextBox.TabIndex = 0;
            this.BarcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodeTextBox.TextChanged += new System.EventHandler(this.BarcodeTextBox_TextChanged);
            this.BarcodeTextBox.Enter += new System.EventHandler(this.BarcodeTextBox_Enter);
            this.BarcodeTextBox.Leave += new System.EventHandler(this.BarcodeTextBox_Leave);
            // 
            // BarcodeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.BarcodeTextBox);
            this.Name = "BarcodeBox";
            this.Size = new System.Drawing.Size(450, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox BarcodeTextBox;
    }
}
