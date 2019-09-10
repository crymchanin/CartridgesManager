namespace CartridgesManager.Controls {
    partial class UserSelect {
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ContentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseTabButton = new CartridgesManager.Controls.ButtonWithBarcode();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Controls.Add(this.ContentLayoutPanel);
            this.ContentPanel.Location = new System.Drawing.Point(55, 55);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(498, 395);
            this.ContentPanel.TabIndex = 1;
            // 
            // ContentLayoutPanel
            // 
            this.ContentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentLayoutPanel.Name = "ContentLayoutPanel";
            this.ContentLayoutPanel.Size = new System.Drawing.Size(498, 395);
            this.ContentLayoutPanel.TabIndex = 0;
            // 
            // CloseTabButton
            // 
            this.CloseTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseTabButton.BackColor = System.Drawing.Color.White;
            this.CloseTabButton.Barcode = "";
            this.CloseTabButton.ButtonBackColor = System.Drawing.Color.LightSkyBlue;
            this.CloseTabButton.ButtonImage = global::CartridgesManager.Properties.Resources.remove_64;
            this.CloseTabButton.ButtonText = "Закрыть окно";
            this.CloseTabButton.Location = new System.Drawing.Point(574, 213);
            this.CloseTabButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.CloseTabButton.Name = "CloseTabButton";
            this.CloseTabButton.Size = new System.Drawing.Size(207, 215);
            this.CloseTabButton.TabIndex = 0;
            // 
            // UserSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.CloseTabButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "UserSelect";
            this.Size = new System.Drawing.Size(800, 450);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonWithBarcode CloseTabButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.FlowLayoutPanel ContentLayoutPanel;
    }
}
