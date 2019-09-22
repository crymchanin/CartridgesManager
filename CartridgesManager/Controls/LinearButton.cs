using BarcodeLib;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class LinearButton : UserControl, ICodeButton {

        private string _barcode = string.Empty;
        private object _customData;
        private bool _compactMode;
        private Image _buttonOldImage;
        private bool _checked;
        private Color _backColor = Color.DimGray;
        private Color _checkedBackColor = Color.Green;


        /// <summary>
        /// Происходит при нажатии кнопки
        /// </summary>
        public event CodeButtonClickEventHandler ButtonClick;


        /// <summary>
        /// Создает новый экземпляр класса BarcodeButton
        /// </summary>
        public LinearButton() : base() {
            InitializeComponent();

            FlatButton.Click += (s, e) => ButtonClick?.Invoke(this, e);
        }

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
        /// Переключает обычный и компактный режимы элемента управления
        /// </summary>
        [Category("Appearance")]
        [Description("Режимы отображения элемента управления")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool CompactMode {
            get {
                return _compactMode;
            }
            set {
                _compactMode = value;
                if (_compactMode) {
                    FlatButton.Height = 50;
                    MinimumSize = new Size(Width, 105);
                    Height = 105;
                    FontSize = 9.25F;

                    if (FlatButton.Image != null) {
                        _buttonOldImage = FlatButton.Image;
                        FlatButton.TextImageRelation = TextImageRelation.Overlay;
                        FlatButton.ImageAlign = ContentAlignment.MiddleLeft;
                        FlatButton.TextAlign = ContentAlignment.MiddleRight;
                        FlatButton.Image = GuiController.ResizeImage(FlatButton.Image, 32, 32);
                    }
                }
                else {
                    FlatButton.Height = 160;
                    MinimumSize = new Size(Width, 215);
                    Height = 215;

                    FlatButton.TextImageRelation = TextImageRelation.TextAboveImage;
                    FlatButton.ImageAlign = ContentAlignment.TopCenter;
                    FlatButton.TextAlign = ContentAlignment.MiddleCenter;
                    FontSize = 14.25F;
                    if (_buttonOldImage != null) {
                        FlatButton.Image = _buttonOldImage;
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает или задает штрихкод кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Штрихкод кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Barcode {
            get {
                return _barcode;
            }
            set {
                _barcode = value;
                if (!string.IsNullOrEmpty(_barcode)) {
                    Barcode barcode = new Barcode {
                        Alignment = AlignmentPositions.CENTER,
                        Width = BarcodeBox.Width,
                        Height = BarcodeBox.Height
                    };
                    Image img = barcode.Encode(TYPE.CODE39, _barcode);
                    BarcodeBox.SizeMode = PictureBoxSizeMode.Zoom;
                    BarcodeBox.Image = (Image)img.Clone();
                }
            }
        }

        /// <summary>
        /// Тип штрихкода, который будет отображен в кнопке
        /// </summary>
        public CodeButtonType BarcodeType => CodeButtonType.LinearCode;

        /// <summary>
        /// Возвращает или задает изображение, отображаемое в кнопке
        /// </summary>
        [Category("Appearance")]
        [Description("Изображение отображаемое в кнопке")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image {
            get => FlatButton.Image;
            set => FlatButton.Image = value;
        }

        /// <summary>
        /// Возвращает или задает текст, связанный с кнопкой
        /// </summary>
        [Category("Appearance")]
        [Description("Текст кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorAttribute("System.ComponentModel.Design.MultilineStringEditor, System.Design", "System.Drawing.Design.UITypeEditor")]
        public string ButtonText {
            get {
                return FlatButton.Text;
            }
            set {
                FlatButton.Text = value;
            }
        }

        /// <summary>
        /// Возвращает или задает цвет фона кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Цвет фона кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ButtonBackColor {
            get {
                return _backColor;
            }
            set {
                _backColor = value;
                FlatButton.BackColor = _backColor;
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
        public Color ButtonForeColor {
            get => FlatButton.ForeColor;
            set => FlatButton.ForeColor = value;
        }

        /// <summary>
        /// Возвращает или задает шрифт текста, отображаемого элементом управления
        /// </summary>
        [Category("Appearance")]
        [Description("Шрифт, используемый для отображения текста на элементе управления.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font ButtonFont {
            get => FlatButton.Font;
            set => FlatButton.Font = value;
        }

        /// <summary>
        /// Возвращает или задает цвет фона кнопки в выбранном состоянии
        /// </summary>
        [Category("Appearance")]
        [Description("Цвет фона кнопки в выбранном состоянии")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color CheckedBackColor {
            get => _checkedBackColor;
            set {
                _checkedBackColor = value;
                if (_checked) {
                    FlatButton.BackColor = _checkedBackColor;
                }
            }
        }

        /// <summary>
        /// Возвращает или задает размер шрифта кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Размер шрифта кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float FontSize {
            get => FlatButton.Font.Size;
            set => FlatButton.Font = new Font(FlatButton.Font.FontFamily, value, FlatButton.Font.Style, FlatButton.Font.Unit, FlatButton.Font.GdiCharSet);
        }

        /// <summary>
        /// Возвращает или задает значение отмечена ли кнопка выбранной или нет
        /// </summary>
        [Category("Appearance")]
        [Description("Определяет отмечена ли кнопка выбранной или нет")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Checked {
            get {
                return _checked;
            }
            set {
                _checked = value;
                FlatButton.BackColor = (_checked) ? CheckedBackColor : _backColor;
            }
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
