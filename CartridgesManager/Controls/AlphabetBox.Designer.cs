namespace CartridgesManager.Controls {
    partial class AlphabetBox {
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
            this.ContentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ContentLayoutPanel
            // 
            this.ContentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentLayoutPanel.Name = "ContentLayoutPanel";
            this.ContentLayoutPanel.Size = new System.Drawing.Size(920, 330);
            this.ContentLayoutPanel.TabIndex = 0;
            // 
            // AlphabetBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ContentLayoutPanel);
            this.Name = "AlphabetBox";
            this.Size = new System.Drawing.Size(920, 330);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ContentLayoutPanel;
    }
}
