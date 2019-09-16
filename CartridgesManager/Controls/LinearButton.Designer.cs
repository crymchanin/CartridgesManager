namespace CartridgesManager.Controls {
    partial class LinearButton {
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
            this.BarcodeBox = new System.Windows.Forms.PictureBox();
            this.FlatButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeBox.Location = new System.Drawing.Point(0, 165);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(207, 50);
            this.BarcodeBox.TabIndex = 13;
            this.BarcodeBox.TabStop = false;
            // 
            // FlatButton
            // 
            this.FlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatButton.BackColor = System.Drawing.Color.DimGray;
            this.FlatButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlatButton.FlatAppearance.BorderSize = 2;
            this.FlatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatButton.ForeColor = System.Drawing.Color.White;
            this.FlatButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FlatButton.Location = new System.Drawing.Point(0, 0);
            this.FlatButton.Name = "FlatButton";
            this.FlatButton.Size = new System.Drawing.Size(207, 160);
            this.FlatButton.TabIndex = 0;
            this.FlatButton.Tag = "";
            this.FlatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.FlatButton.UseVisualStyleBackColor = false;
            this.FlatButton.Click += new System.EventHandler(this.FlatButton_Click);
            // 
            // ButtonWithBarcode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.FlatButton);
            this.MinimumSize = new System.Drawing.Size(207, 215);
            this.Name = "ButtonWithBarcode";
            this.Size = new System.Drawing.Size(207, 215);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BarcodeBox;
        private System.Windows.Forms.Button FlatButton;
    }
}
