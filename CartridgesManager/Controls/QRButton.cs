using QRCoder;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public class QRButton : BaseCodeButton {

        private string _barcode = string.Empty;
        private object _customData;
        private bool _checked;
        private Color _backColor = Color.DimGray;
        private Button InnerButton;
        private Color _checkedBackColor = Color.Green;

        /// <summary>
        /// Происходит при нажатии кнопки
        /// </summary>
        public override event CodeButtonClickEventHandler ButtonClick;


        private Bitmap GenerateQrCode(string plainText) {
            QRCodeGenerator gen = new QRCodeGenerator();
            QRCodeData data = gen.CreateQrCode(plainText, QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(data);

            return code.GetGraphic(2);
        }

        /// <summary>
        /// Создает новый экземпляр класса QRButton
        /// </summary>
        public QRButton() : base() {
            InitializeComponent();
            _backColor = Color.DimGray;

            InnerButton.Click += (s, e) => ButtonClick?.Invoke(this, e);
        }

        /// <summary>
        /// Возвращает или задает штрихкод кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Штрихкод кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public override string Barcode {
            get => _barcode;
            set {
                _barcode = value;
                if (!string.IsNullOrEmpty(_barcode.Trim())) {
                    Image = GenerateQrCode(_barcode);
                }
            }
        }

        /// <summary>
        /// Возвращает тип штрихкода данной кнопки
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override CodeButtonType BarcodeType { get => CodeButtonType.QRCode; }

        /// <summary>
        /// Возвращает пользовательские данные связанные с тукущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип возвращаемых данных</typeparam>
        /// <returns></returns>
        public override T GetCustomData<T>() {
            return (T)_customData;
        }

        /// <summary>
        /// Связывает указанные пользовательские данные с текущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип связываемых данных</typeparam>
        /// <param name="customData">Пользовательские данные</param>
        public override void SetCustomData<T>(T customData) {
            _customData = customData;
        }

        /// <summary>
        /// Возвращает или pадает изображение, отображаемое на кнопке
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Image Image {
            get => InnerButton.Image;
            set => InnerButton.Image = value;
        }

        /// <summary>
        /// Возвращает или задает текст, связанный с этим элементом управления
        /// </summary>
        [Category("Appearance")]
        [Description("Текст связанный с элементом управления")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public override string Text { get => InnerButton.Text; set => InnerButton.Text = value; }

        /// <summary>
        /// Возвращает или задает цвет фона элемента управления
        /// </summary>
        [Category("Appearance")]
        [Description("Фоновый цвет компонента")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "DimGray")]
        public override Color BackColor {
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
        public override Color ForeColor { get => InnerButton.ForeColor; set => InnerButton.ForeColor = value; }

        /// <summary>
        /// Возвращает или задает шрифт текста, отображаемого элементом управления
        /// </summary>
        [Category("Appearance")]
        [Description("Шрифт, используемый для отображения текста на элементе управления.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font { get => InnerButton.Font; set => InnerButton.Font = value; }

        /// <summary>
        /// Возвращает или задает значение отмечена ли кнопка выбранной или нет
        /// </summary>
        [Category("Appearance")]
        [Description("Определяет отмечена ли кнопка выбранной или нет")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public override bool Checked {
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
        public override Color CheckedBackColor {
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
            this.SuspendLayout();
            // 
            // InnerButton
            // 
            this.InnerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InnerButton.FlatAppearance.BorderSize = 2;
            this.InnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InnerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InnerButton.TextImageRelation = TextImageRelation.Overlay;
            this.InnerButton.Location = new System.Drawing.Point(0, 0);
            this.InnerButton.Name = "InnerButton";
            this.InnerButton.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.InnerButton.Size = new System.Drawing.Size(240, 68);
            this.InnerButton.TabIndex = 0;
            this.InnerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InnerButton.UseVisualStyleBackColor = true;
            // 
            // QRButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ((Control)this).BackColor = System.Drawing.Color.Transparent;
            BackColor = _backColor;
            this.Controls.Add(this.InnerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QRButton";
            this.Size = new System.Drawing.Size(240, 72);
            this.ResumeLayout(false);

        }
    }
}
