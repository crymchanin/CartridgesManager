using QRCoder;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public class QRButton : BaseCodeButton {

        private string _barcode;
        private object _customData;
        private bool _checked;
        private Color _backColor;
        private Color _checkedBackColor = Color.Green;


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

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 2;
            FlatAppearance.BorderColor = Color.Black;
            BackColor = _backColor = Color.DimGray;
            TextAlign = ContentAlignment.MiddleRight;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextImageRelation = TextImageRelation.Overlay;
            ForeColor = Color.White;
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Padding = new Padding(2, 2, 10, 2);
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
                Image = GenerateQrCode(_barcode);
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
        /// Возвращает или задает изображение, отображаемое на кнопке
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image Image {
            get => base.Image;
            private set {
                base.Image = value;
            }
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
                BackColor = (_checked) ? CheckedBackColor : _backColor;
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
                    BackColor = _checkedBackColor;
                }
            }
        }
    }
}
