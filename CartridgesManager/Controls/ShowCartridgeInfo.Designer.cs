namespace CartridgesManager.Controls {
    partial class ShowCartridgeInfo {
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.Label();
            this.LocationBox = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.InitiatorBox = new System.Windows.Forms.Label();
            this.InitiatorLabel = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.OpertionsBox = new System.Windows.Forms.ListView();
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.CloseTabButton = new CartridgesManager.Controls.LinearButton();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLabel.Location = new System.Drawing.Point(15, 28);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(60, 16);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Номер:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.Location = new System.Drawing.Point(16, 85);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(152, 16);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Модель картриджа:";
            // 
            // ModelBox
            // 
            this.ModelBox.AutoSize = true;
            this.ModelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelBox.Location = new System.Drawing.Point(15, 107);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(0, 20);
            this.ModelBox.TabIndex = 3;
            // 
            // LocationBox
            // 
            this.LocationBox.AutoSize = true;
            this.LocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationBox.Location = new System.Drawing.Point(15, 164);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(0, 20);
            this.LocationBox.TabIndex = 5;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationLabel.Location = new System.Drawing.Point(16, 142);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(140, 16);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "Место установки:";
            // 
            // InitiatorBox
            // 
            this.InitiatorBox.AutoSize = true;
            this.InitiatorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitiatorBox.Location = new System.Drawing.Point(14, 221);
            this.InitiatorBox.Name = "InitiatorBox";
            this.InitiatorBox.Size = new System.Drawing.Size(0, 20);
            this.InitiatorBox.TabIndex = 7;
            // 
            // InitiatorLabel
            // 
            this.InitiatorLabel.AutoSize = true;
            this.InitiatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitiatorLabel.Location = new System.Drawing.Point(15, 199);
            this.InitiatorLabel.Name = "InitiatorLabel";
            this.InitiatorLabel.Size = new System.Drawing.Size(59, 16);
            this.InitiatorLabel.TabIndex = 6;
            this.InitiatorLabel.Text = "Выдал:";
            // 
            // DataBox
            // 
            this.DataBox.AutoSize = true;
            this.DataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataBox.Location = new System.Drawing.Point(15, 278);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(0, 20);
            this.DataBox.TabIndex = 9;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(16, 256);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(107, 16);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Дата выдачи:";
            // 
            // StateBox
            // 
            this.StateBox.AutoSize = true;
            this.StateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateBox.Location = new System.Drawing.Point(15, 335);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(0, 20);
            this.StateBox.TabIndex = 11;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(16, 313);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(124, 16);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = "Тип картриджа:";
            // 
            // OpertionsBox
            // 
            this.OpertionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpertionsBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateHeader,
            this.TypeHeader,
            this.PartNameHeader,
            this.PartCountHeader,
            this.WorkerNameHeader,
            this.CommentHeader});
            this.OpertionsBox.FullRowSelect = true;
            this.OpertionsBox.GridLines = true;
            this.OpertionsBox.Location = new System.Drawing.Point(279, 28);
            this.OpertionsBox.Name = "OpertionsBox";
            this.OpertionsBox.Size = new System.Drawing.Size(894, 744);
            this.OpertionsBox.TabIndex = 2;
            this.OpertionsBox.UseCompatibleStateImageBehavior = false;
            this.OpertionsBox.View = System.Windows.Forms.View.Details;
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Дата обслуживания";
            this.DateHeader.Width = 150;
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Выполненная работа";
            this.TypeHeader.Width = 180;
            // 
            // PartNameHeader
            // 
            this.PartNameHeader.Text = "Имя комплектующего";
            this.PartNameHeader.Width = 170;
            // 
            // PartCountHeader
            // 
            this.PartCountHeader.Text = "Затрачено";
            this.PartCountHeader.Width = 90;
            // 
            // WorkerNameHeader
            // 
            this.WorkerNameHeader.Text = "Фамилия работника";
            this.WorkerNameHeader.Width = 150;
            // 
            // CommentHeader
            // 
            this.CommentHeader.Text = "Коментарий";
            this.CommentHeader.Width = 150;
            // 
            // NumberBox
            // 
            this.NumberBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberBox.Location = new System.Drawing.Point(15, 48);
            this.NumberBox.MaxLength = 14;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(248, 26);
            this.NumberBox.TabIndex = 0;
            this.NumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            // 
            // CloseTabButton
            // 
            this.CloseTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseTabButton.BackColor = System.Drawing.Color.White;
            this.CloseTabButton.Barcode = "";
            this.CloseTabButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CloseTabButton.FontSize = 14.25F;
            this.CloseTabButton.Image = global::CartridgesManager.Properties.Resources.remove_64;
            this.CloseTabButton.Text = "Закрыть окно";
            this.CloseTabButton.CompactMode = false;
            this.CloseTabButton.Location = new System.Drawing.Point(29, 557);
            this.CloseTabButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.CloseTabButton.Name = "CloseTabButton";
            this.CloseTabButton.Size = new System.Drawing.Size(207, 215);
            this.CloseTabButton.TabIndex = 1;
            // 
            // ShowCartridgeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.CloseTabButton);
            this.Controls.Add(this.OpertionsBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.InitiatorBox);
            this.Controls.Add(this.InitiatorLabel);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.NumberLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ShowCartridgeInfo";
            this.Size = new System.Drawing.Size(1200, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ModelBox;
        private System.Windows.Forms.Label LocationBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label InitiatorBox;
        private System.Windows.Forms.Label InitiatorLabel;
        private System.Windows.Forms.Label DataBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label StateBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ListView OpertionsBox;
        private System.Windows.Forms.ColumnHeader DateHeader;
        private System.Windows.Forms.ColumnHeader TypeHeader;
        private System.Windows.Forms.ColumnHeader PartNameHeader;
        private System.Windows.Forms.ColumnHeader PartCountHeader;
        private System.Windows.Forms.ColumnHeader WorkerNameHeader;
        private System.Windows.Forms.ColumnHeader CommentHeader;
        private LinearButton CloseTabButton;
        private System.Windows.Forms.TextBox NumberBox;
    }
}
