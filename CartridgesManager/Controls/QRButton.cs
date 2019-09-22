using QRCoder;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public class QRButton : UserControl, ICodeButton {

        private string _barcode = string.Empty;
        private object _customData;
        private bool _checked;
        private Color _backColor = Color.DimGray;
        private Button InnerButton;
        private PictureBox InnerPictureBox;
        private Color _checkedBackColor = Color.Green;

        /// <summary>
        /// Происходит при нажатии кнопки
        /// </summary>
        public event CodeButtonClickEventHandler ButtonClick;


        private Bitmap GenerateQrCode(string plainText) {
            QRCodeGenerator gen = new QRCodeGenerator();
            QRCodeData data = gen.CreateQrCode(plainText, QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(data);

            return code.GetGraphic(3);
        }

        /// <summary>
        /// Создает новый экземпляр класса QRButton
        /// </summary>
        public QRButton() {
            InitializeComponent();

            Click += (s, e) => ButtonClick?.Invoke(this, e);
            foreach (Control ctrl in Controls) {
                ctrl.Click += (s, e) => ButtonClick?.Invoke(this, e);
            }
        }

        /// <summary>
        /// Возвращает или задает штрихкод кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Штрихкод кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public string Barcode {
            get => _barcode;
            set {
                _barcode = value;
                if (!string.IsNullOrEmpty(_barcode)) {
                    Image = GenerateQrCode(_barcode);
                }
            }
        }

        /// <summary>
        /// Возвращает тип штрихкода данной кнопки
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CodeButtonType BarcodeType { get => CodeButtonType.QRCode; }

        /// <summary>
        /// Возвращает пользовательские данные связанные с тукущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип возвращаемых данных</typeparam>
        /// <returns></returns>
        public T GetCustomData<T>() {
            return (T)_customData;
        }

        /// <summary>
        /// Связывает указанные пользовательские данные с текущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип связываемых данных</typeparam>
        /// <param name="customData">Пользовательские данные</param>
        public void SetCustomData<T>(T customData) {
            _customData = customData;
        }

        /// <summary>
        /// Возвращает или pадает изображение, отображаемое на кнопке
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image {
            get => InnerPictureBox.Image;
            set => InnerPictureBox.Image = value;
        }

        /// <summary>
        /// Возвращает или задает текст, связанный с этим элементом управления
        /// </summary>
        [Category("Appearance")]
        [Description("Текст связанный с элементом управления")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public string ButtonText {
            get => InnerButton.Text;
            set => InnerButton.Text = value;
        }

        /// <summary>
        /// Возвращает или задает цвет фона элемента управления
        /// </summary>
        [Category("Appearance")]
        [Description("Фоновый цвет компонента")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "DimGray")]
        public Color ButtonBackColor {
            get => InnerButton.BackColor;
            set {
                _backColor = value;
                InnerButton.BackColor = _backColor;
            }
        }

        /// <summary>
        /// Возвращает или задает цвет элемента управления
        /// </summary>
        [Category("Appearance")]
        [Description("Цвет переднего плана для отображения текста в данном элементе управления")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "White")]
        public Color ButtonForeColor { get => InnerButton.ForeColor; set => InnerButton.ForeColor = value; }

        /// <summary>
        /// Возвращает или задает шрифт текста, отображаемого элементом управления
        /// </summary>
        [Category("Appearance")]
        [Description("Шрифт, используемый для отображения текста на элементе управления.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font ButtonFont { get => InnerButton.Font; set => InnerButton.Font = value; }

        /// <summary>
        /// Возвращает или задает размер шрифта кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Размер шрифта кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float FontSize {
            get => InnerButton.Font.Size;
            set => InnerButton.Font = new Font(InnerButton.Font.FontFamily, value, InnerButton.Font.Style, InnerButton.Font.Unit, InnerButton.Font.GdiCharSet);
        }

        /// <summary>
        /// Возвращает или задает значение отмечена ли кнопка выбранной или нет
        /// </summary>
        [Category("Appearance")]
        [Description("Определяет отмечена ли кнопка выбранной или нет")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool Checked {
            get => _checked;
            set {
                _checked = value;
                InnerButton.BackColor = (_checked) ? CheckedBackColor : _backColor;
            }
        }

        /// <summary>
        /// Возвращает или задает цвет фона кнопки в выбранном состоянии
        /// </summary>
        [Category("Appearance")]
        [Description("Цвет фона кнопки в выбранном состоянии")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Green")]
        public Color CheckedBackColor {
            get => _checkedBackColor;
            set {
                _checkedBackColor = value;
                if (_checked) {
                    InnerButton.BackColor = _checkedBackColor;
                }
            }
        }


        private void InitializeComponent() {
            this.InnerButton = new System.Windows.Forms.Button();
            this.InnerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InnerButton
            // 
            this.InnerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InnerButton.AutoEllipsis = true;
            this.InnerButton.BackColor = System.Drawing.Color.DimGray;
            this.InnerButton.FlatAppearance.BorderSize = 0;
            this.InnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InnerButton.Location = new System.Drawing.Point(78, 2);
            this.InnerButton.Margin = new System.Windows.Forms.Padding(0);
            this.InnerButton.Name = "InnerButton";
            this.InnerButton.Size = new System.Drawing.Size(190, 76);
            this.InnerButton.TabIndex = 0;
            this.InnerButton.UseVisualStyleBackColor = false;
            // 
            // InnerPictureBox
            // 
            this.InnerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InnerPictureBox.BackColor = System.Drawing.Color.White;
            this.InnerPictureBox.Location = new System.Drawing.Point(2, 2);
            this.InnerPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.InnerPictureBox.Name = "InnerPictureBox";
            this.InnerPictureBox.Size = new System.Drawing.Size(76, 76);
            this.InnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InnerPictureBox.TabIndex = 1;
            this.InnerPictureBox.TabStop = false;
            // 
            // QRButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.InnerPictureBox);
            this.Controls.Add(this.InnerButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QRButton";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(270, 80);
            ((System.ComponentModel.ISupportInitialize)(this.InnerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #region Скрытие неиспользуемых свойств
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text { get => base.Text; set => base.Text = value; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font { get => base.Font; set => base.Font = value; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override ImageLayout BackgroundImageLayout { get => base.BackgroundImageLayout; set => base.BackgroundImageLayout = value; }
        #endregion
    }
}
