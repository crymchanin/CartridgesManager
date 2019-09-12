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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainStrip = new System.Windows.Forms.StatusStrip();
            this.TimeStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.WhitespaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentOperationStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainControl1 = new CartridgesManager.Controls.MainControl();
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStrip
            // 
            this.MainStrip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStripLabel,
            this.WhitespaceLabel,
            this.CurrentOperationStripLabel});
            this.MainStrip.Location = new System.Drawing.Point(0, 673);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(954, 29);
            this.MainStrip.TabIndex = 1;
            // 
            // TimeStripLabel
            // 
            this.TimeStripLabel.Image = global::CartridgesManager.Properties.Resources.clock_32;
            this.TimeStripLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeStripLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TimeStripLabel.Name = "TimeStripLabel";
            this.TimeStripLabel.Size = new System.Drawing.Size(32, 24);
            // 
            // WhitespaceLabel
            // 
            this.WhitespaceLabel.Name = "WhitespaceLabel";
            this.WhitespaceLabel.Size = new System.Drawing.Size(907, 24);
            this.WhitespaceLabel.Spring = true;
            // 
            // CurrentOperationStripLabel
            // 
            this.CurrentOperationStripLabel.Name = "CurrentOperationStripLabel";
            this.CurrentOperationStripLabel.Size = new System.Drawing.Size(0, 24);
            // 
            // mainControl1
            // 
            this.mainControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainControl1.BackColor = System.Drawing.Color.White;
            this.mainControl1.Location = new System.Drawing.Point(0, 0);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(954, 702);
            this.mainControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 702);
            this.Controls.Add(this.MainStrip);
            this.Controls.Add(this.mainControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(970, 740);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картриджи";
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MainControl mainControl1;
        private System.Windows.Forms.StatusStrip MainStrip;
        private System.Windows.Forms.ToolStripStatusLabel TimeStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel WhitespaceLabel;
        public System.Windows.Forms.ToolStripStatusLabel CurrentOperationStripLabel;
    }
}

