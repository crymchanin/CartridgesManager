namespace CartridgesManager.Controls {
    partial class ServiceCartridge {
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
            this.label4 = new System.Windows.Forms.Label();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WorkerBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new CartridgesManager.Controls.LinearButton();
            this.CloseTabButton = new CartridgesManager.Controls.LinearButton();
            this.ContentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.paginationControl1 = new CartridgesManager.Controls.PaginationControl();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(792, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Место установки";
            // 
            // LocationBox
            // 
            this.LocationBox.BackColor = System.Drawing.Color.LightGray;
            this.LocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationBox.Location = new System.Drawing.Point(795, 100);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.ReadOnly = true;
            this.LocationBox.Size = new System.Drawing.Size(357, 26);
            this.LocationBox.TabIndex = 0;
            this.LocationBox.TabStop = false;
            this.LocationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(402, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата операции";
            // 
            // DateBox
            // 
            this.DateBox.BackColor = System.Drawing.Color.LightGray;
            this.DateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.Location = new System.Drawing.Point(405, 100);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(357, 26);
            this.DateBox.TabIndex = 0;
            this.DateBox.TabStop = false;
            this.DateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Номер картриджа";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1139, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Обслуживание картриджа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(792, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Выполнил";
            // 
            // WorkerBox
            // 
            this.WorkerBox.BackColor = System.Drawing.Color.LightGray;
            this.WorkerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkerBox.Location = new System.Drawing.Point(795, 159);
            this.WorkerBox.Name = "WorkerBox";
            this.WorkerBox.ReadOnly = true;
            this.WorkerBox.Size = new System.Drawing.Size(357, 26);
            this.WorkerBox.TabIndex = 0;
            this.WorkerBox.TabStop = false;
            this.WorkerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(402, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Комментарий";
            // 
            // CommentBox
            // 
            this.CommentBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CommentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentBox.Location = new System.Drawing.Point(405, 159);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(357, 26);
            this.CommentBox.TabIndex = 1;
            this.CommentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Модель картриджа";
            // 
            // ModelBox
            // 
            this.ModelBox.BackColor = System.Drawing.Color.LightGray;
            this.ModelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelBox.Location = new System.Drawing.Point(17, 159);
            this.ModelBox.MaxLength = 14;
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.ReadOnly = true;
            this.ModelBox.Size = new System.Drawing.Size(357, 26);
            this.ModelBox.TabIndex = 0;
            this.ModelBox.TabStop = false;
            this.ModelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Barcode = "";
            this.SaveButton.ButtonBackColor = System.Drawing.Color.MediumAquamarine;
            this.SaveButton.ButtonChecked = false;
            this.SaveButton.ButtonCheckedBackColor = System.Drawing.Color.Green;
            this.SaveButton.ButtonFontSize = 14.25F;
            this.SaveButton.ButtonImage = global::CartridgesManager.Properties.Resources.save_64;
            this.SaveButton.ButtonText = "Сохранить данные";
            this.SaveButton.CompactMode = false;
            this.SaveButton.Location = new System.Drawing.Point(971, 342);
            this.SaveButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(207, 215);
            this.SaveButton.TabIndex = 2;
            // 
            // CloseTabButton
            // 
            this.CloseTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseTabButton.BackColor = System.Drawing.Color.White;
            this.CloseTabButton.Barcode = "";
            this.CloseTabButton.ButtonBackColor = System.Drawing.Color.LightSkyBlue;
            this.CloseTabButton.ButtonChecked = false;
            this.CloseTabButton.ButtonCheckedBackColor = System.Drawing.Color.Green;
            this.CloseTabButton.ButtonFontSize = 14.25F;
            this.CloseTabButton.ButtonImage = global::CartridgesManager.Properties.Resources.remove_64;
            this.CloseTabButton.ButtonText = "Закрыть окно";
            this.CloseTabButton.CompactMode = false;
            this.CloseTabButton.Location = new System.Drawing.Point(971, 563);
            this.CloseTabButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.CloseTabButton.Name = "CloseTabButton";
            this.CloseTabButton.Size = new System.Drawing.Size(207, 215);
            this.CloseTabButton.TabIndex = 3;
            // 
            // ContentLayoutPanel
            // 
            this.ContentLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentLayoutPanel.Location = new System.Drawing.Point(17, 245);
            this.ContentLayoutPanel.Name = "ContentLayoutPanel";
            this.ContentLayoutPanel.Size = new System.Drawing.Size(929, 16);
            this.ContentLayoutPanel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Выполненные работы";
            // 
            // paginationControl1
            // 
            this.paginationControl1.BackColor = System.Drawing.Color.White;
            this.paginationControl1.Location = new System.Drawing.Point(17, 278);
            this.paginationControl1.Name = "paginationControl1";
            this.paginationControl1.NavigationPanelHeight = 150;
            this.paginationControl1.Size = new System.Drawing.Size(800, 500);
            this.paginationControl1.TabIndex = 25;
            // 
            // ServiceCartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.paginationControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ContentLayoutPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseTabButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WorkerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ServiceCartridge";
            this.Size = new System.Drawing.Size(1200, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WorkerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ModelBox;
        private LinearButton SaveButton;
        private LinearButton CloseTabButton;
        private System.Windows.Forms.FlowLayoutPanel ContentLayoutPanel;
        private System.Windows.Forms.Label label8;
        private PaginationControl paginationControl1;
    }
}
