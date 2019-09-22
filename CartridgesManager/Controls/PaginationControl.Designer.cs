namespace CartridgesManager.Controls {
    partial class PaginationControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginationControl));
            this.NavPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ContentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BackwardButton = new CartridgesManager.Controls.LinearButton();
            this.CloseButton = new CartridgesManager.Controls.LinearButton();
            this.ForwardButton = new CartridgesManager.Controls.LinearButton();
            this.NavPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavPanel.Controls.Add(this.CloseButton);
            this.NavPanel.Controls.Add(this.ForwardButton);
            this.NavPanel.Controls.Add(this.BackwardButton);
            this.NavPanel.Location = new System.Drawing.Point(0, 350);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(800, 150);
            this.NavPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.ContentLayoutPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 350);
            this.MainPanel.TabIndex = 0;
            // 
            // ContentLayoutPanel
            // 
            this.ContentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentLayoutPanel.Name = "ContentLayoutPanel";
            this.ContentLayoutPanel.Size = new System.Drawing.Size(800, 350);
            this.ContentLayoutPanel.TabIndex = 0;
            // 
            // BackwardButton
            // 
            this.BackwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackwardButton.Barcode = "";
            this.BackwardButton.ButtonBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackwardButton.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackwardButton.ButtonText = "Назад";
            this.BackwardButton.Checked = false;
            this.BackwardButton.CheckedBackColor = System.Drawing.Color.Green;
            this.BackwardButton.CompactMode = true;
            this.BackwardButton.FontSize = 9.25F;
            this.BackwardButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardButton.Image")));
            this.BackwardButton.Location = new System.Drawing.Point(22, 22);
            this.BackwardButton.MinimumSize = new System.Drawing.Size(207, 105);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(207, 105);
            this.BackwardButton.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Barcode = "";
            this.CloseButton.ButtonBackColor = System.Drawing.Color.LightSkyBlue;
            this.CloseButton.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ButtonText = "Закрыть";
            this.CloseButton.Checked = false;
            this.CloseButton.CheckedBackColor = System.Drawing.Color.Green;
            this.CloseButton.CompactMode = true;
            this.CloseButton.FontSize = 9.25F;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(571, 22);
            this.CloseButton.MinimumSize = new System.Drawing.Size(207, 105);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(207, 105);
            this.CloseButton.TabIndex = 2;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ForwardButton.Barcode = "";
            this.ForwardButton.ButtonBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ForwardButton.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardButton.ButtonText = "Вперед";
            this.ForwardButton.Checked = false;
            this.ForwardButton.CheckedBackColor = System.Drawing.Color.Green;
            this.ForwardButton.CompactMode = true;
            this.ForwardButton.FontSize = 9.25F;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.Location = new System.Drawing.Point(235, 22);
            this.ForwardButton.MinimumSize = new System.Drawing.Size(207, 105);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(207, 105);
            this.ForwardButton.TabIndex = 1;
            // 
            // PaginationControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "PaginationControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.NavPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.FlowLayoutPanel ContentLayoutPanel;
        private LinearButton CloseButton;
        private LinearButton ForwardButton;
        private LinearButton BackwardButton;
    }
}
