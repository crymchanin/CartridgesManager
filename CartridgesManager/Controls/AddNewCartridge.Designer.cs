namespace CartridgesManager.Controls {
    partial class AddNewCartridge {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCartridge));
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkerBox = new System.Windows.Forms.TextBox();
            this.TypeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ModelsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LocationsBox = new CartridgesManager.Controls.AlphabetBox();
            this.SaveButton = new CartridgesManager.Controls.BarcodeButton();
            this.CloseTabButton = new CartridgesManager.Controls.BarcodeButton();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeBox.Location = new System.Drawing.Point(17, 100);
            this.CodeBox.MaxLength = 14;
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(357, 26);
            this.CodeBox.TabIndex = 0;
            this.CodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1139, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление нового картриджа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер картриджа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(402, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата операции";
            // 
            // DateBox
            // 
            this.DateBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.Location = new System.Drawing.Point(405, 100);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(357, 26);
            this.DateBox.TabIndex = 1;
            this.DateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(792, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выполнил";
            // 
            // WorkerBox
            // 
            this.WorkerBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.WorkerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkerBox.Location = new System.Drawing.Point(795, 100);
            this.WorkerBox.Name = "WorkerBox";
            this.WorkerBox.ReadOnly = true;
            this.WorkerBox.Size = new System.Drawing.Size(357, 26);
            this.WorkerBox.TabIndex = 2;
            this.WorkerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeLayoutPanel
            // 
            this.TypeLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeLayoutPanel.Location = new System.Drawing.Point(962, 167);
            this.TypeLayoutPanel.Name = "TypeLayoutPanel";
            this.TypeLayoutPanel.Size = new System.Drawing.Size(207, 383);
            this.TypeLayoutPanel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(959, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип картриджа";
            // 
            // ModelsLayoutPanel
            // 
            this.ModelsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelsLayoutPanel.Location = new System.Drawing.Point(17, 167);
            this.ModelsLayoutPanel.Name = "ModelsLayoutPanel";
            this.ModelsLayoutPanel.Size = new System.Drawing.Size(920, 240);
            this.ModelsLayoutPanel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Место установки картриджа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Модель картриджа";
            // 
            // LocationsBox
            // 
            this.LocationsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationsBox.BackColor = System.Drawing.Color.White;
            this.LocationsBox.Location = new System.Drawing.Point(17, 444);
            this.LocationsBox.Name = "LocationsBox";
            this.LocationsBox.Size = new System.Drawing.Size(920, 330);
            this.LocationsBox.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Barcode = "";
            this.SaveButton.ButtonBackColor = System.Drawing.Color.MediumAquamarine;
            this.SaveButton.ButtonFontSize = 9.25F;
            this.SaveButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.ButtonImage")));
            this.SaveButton.ButtonText = "Сохранить данные";
            this.SaveButton.CompactMode = true;
            this.SaveButton.Location = new System.Drawing.Point(962, 554);
            this.SaveButton.MinimumSize = new System.Drawing.Size(207, 105);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(207, 105);
            this.SaveButton.TabIndex = 3;
            // 
            // CloseTabButton
            // 
            this.CloseTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseTabButton.BackColor = System.Drawing.Color.White;
            this.CloseTabButton.Barcode = "";
            this.CloseTabButton.ButtonBackColor = System.Drawing.Color.LightSkyBlue;
            this.CloseTabButton.ButtonFontSize = 9.25F;
            this.CloseTabButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("CloseTabButton.ButtonImage")));
            this.CloseTabButton.ButtonText = "Закрыть окно";
            this.CloseTabButton.CompactMode = true;
            this.CloseTabButton.Location = new System.Drawing.Point(962, 669);
            this.CloseTabButton.MinimumSize = new System.Drawing.Size(207, 105);
            this.CloseTabButton.Name = "CloseTabButton";
            this.CloseTabButton.Size = new System.Drawing.Size(207, 105);
            this.CloseTabButton.TabIndex = 4;
            // 
            // AddNewCartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LocationsBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModelsLayoutPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypeLayoutPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WorkerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.CloseTabButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "AddNewCartridge";
            this.Size = new System.Drawing.Size(1200, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BarcodeButton CloseTabButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WorkerBox;
        private System.Windows.Forms.FlowLayoutPanel TypeLayoutPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel ModelsLayoutPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private BarcodeButton SaveButton;
        private AlphabetBox LocationsBox;
    }
}
