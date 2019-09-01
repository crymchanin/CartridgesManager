namespace CartridgesManager.Controls {
    partial class BarcodeControl {
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
            this.BarcodeBox = new System.Windows.Forms.TextBox();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarcodeBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BarcodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BarcodeBox.Location = new System.Drawing.Point(200, 300);
            this.BarcodeBox.MaxLength = 14;
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(402, 29);
            this.BarcodeBox.TabIndex = 0;
            this.BarcodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BarcodeLabel.Location = new System.Drawing.Point(319, 277);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(179, 20);
            this.BarcodeLabel.TabIndex = 1;
            this.BarcodeLabel.Text = "Считайте штрихкод";
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(50, 356);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(684, 24);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "Текущая операция: Показать информацию о картридже";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarcodeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.BarcodeBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "BarcodeControl";
            this.Size = new System.Drawing.Size(800, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BarcodeBox;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label InfoLabel;
    }
}
