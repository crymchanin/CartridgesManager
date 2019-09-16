using BarcodeLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class LinearButton : UserControl {

        private string _barcode = string.Empty;
        private object _customData;
        private bool _compactMode;
        private Image _buttonOldImage;
        private bool _checked;
        private Color _buttonBackColor;


        /// <summary>
        /// Представляет метод, обрабатывающий событие ButtonClick
        /// </summary>
        /// <param name="barcode">Штрихкод</param>
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);

        /// <summary>
        /// Происходит завершении чтения штрихкода
        /// </summary>
        public event ButtonClickEventHandler ButtonClick;


        /// <summary>
        /// Создает новый экземпляр класса BarcodeButton
        /// </summary>
        public LinearButton() {
            InitializeComponent();

            Disposed += ButtonWithBarcode_Disposed;
            _buttonBackColor = FlatButton.BackColor;
        }

        private void ButtonWithBarcode_Disposed(object sender, EventArgs e) {
            this.UnregisterControl();
        }

        private void FlatButton_Click(object sender, EventArgs e) {
            ButtonClick?.Invoke(this, e);
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
                    ButtonFontSize = 9.25F;

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
                    ButtonFontSize = 14.25F;
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
                if (!string.IsNullOrEmpty(_barcode.Trim())) {
                    Barcode barcode = new Barcode();
                    barcode.Alignment = AlignmentPositions.CENTER;
                    barcode.Width = BarcodeBox.Width;
                    barcode.Height = BarcodeBox.Height;
                    Image img = barcode.Encode(TYPE.CODE39, _barcode);
                    BarcodeBox.SizeMode = PictureBoxSizeMode.Zoom;
                    BarcodeBox.Image = (Image)img.Clone();
                }
            }
        }

        /// <summary>
        /// Возвращает или задает текст, связанный с кнопкой
        /// </summary>
        [Category("Appearance")]
        [Description("Текст кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ButtonText {
            get {
                return FlatButton.Text;
            }
            set {
                FlatButton.Text = value;
            }
        }

        /// <summary>
        /// Возвращает или задает изображение, отображаемое в кнопке
        /// </summary>
        [Category("Appearance")]
        [Description("Изображение отображаемое в кнопке")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ButtonImage {
            get {
                return FlatButton.Image;
            }
            set {
                FlatButton.Image = value;
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
                return _buttonBackColor;
            }
            set {
                _buttonBackColor = value;
                FlatButton.BackColor = _buttonBackColor;
            }
        }

        /// <summary>
        /// Возвращает или задает цвет фона кнопки в выбранном состоянии
        /// </summary>
        [Category("Appearance")]
        [Description("Цвет фона кнопки в выбранном состоянии")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ButtonCheckedBackColor { get; set; } = Color.Green;

        /// <summary>
        /// Возвращает или задает размер шрифта кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Размер шрифта кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float ButtonFontSize{
            get {
                return FlatButton.Font.Size;
            }
            set {
                FlatButton.Font = new Font("Microsoft Sans Serif", value, FontStyle.Bold, GraphicsUnit.Point, 204);
            }
        }

        /// <summary>
        /// Возвращает или задает значение отмечена ли кнопка выбранной или нет
        /// </summary>
        [Category("Appearance")]
        [Description("Определяет отмечена ли кнопка выбранной или нет")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ButtonChecked {
            get {
                return _checked;
            }
            set {
                _checked = value;
                FlatButton.BackColor = (_checked) ? ButtonCheckedBackColor : _buttonBackColor;
            }
        }
    }
}
