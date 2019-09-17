using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CartridgesManager.Controls {

    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<BaseCodeButton, UserControl>))]
    public abstract class BaseCodeButton : UserControl, ICodeButton {

        protected BaseCodeButton() {
            Disposed += BaseCodeButton_Disposed;
        }

        /// <summary>
        /// Происходит нажатии кнопки
        /// </summary>
        public abstract event CodeButtonClickEventHandler ButtonClick;

        /// <summary>
        /// Возвращает пользовательские данные связанные с тукущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип возвращаемых данных</typeparam>
        /// <returns></returns>
        public abstract T GetCustomData<T>();

        /// <summary>
        /// Связывает указанные пользовательские данные с текущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип связываемых данных</typeparam>
        /// <param name="customData">Пользовательские данные</param>
        public abstract void SetCustomData<T>(T customData);

        /// <summary>
        /// Возвращает или задает штрихкод кнопки
        /// </summary>
        public abstract string Barcode { get; set; }

        /// <summary>
        /// Тип штрихкода, который будет отображен в кнопке
        /// </summary>
        public abstract CodeButtonType BarcodeType { get; }

        /// <summary>
        /// Возвращает или задает изображение, отображаемое на кнопке
        /// </summary>
        public abstract Image Image { get; set; }

        #pragma warning disable CS0114
        /// <summary>
        /// Возвращает или задает текст, связанный с этим элементом управления
        /// </summary>
        public abstract string Text { get; set; }

        /// <summary>
        /// Возвращает или задает цвет фона элемента управления
        /// </summary>
        public abstract Color BackColor { get; set; }

        /// <summary>
        /// Возвращает или задает цвет элемента управления
        /// </summary>
        public abstract Color ForeColor { get; set; }

        /// <summary>
        /// Возвращает или задает шрифт текста, отображаемого элементом управления
        /// </summary>
        public abstract Font Font { get; set; }
        #pragma warning restore CS0114

        /// <summary>
        /// Возвращает или задает значение отмечена ли кнопка выбранной или нет
        /// </summary>
        public abstract bool Checked { get; set; }

        /// <summary>
        /// Возвращает или задает цвет фона кнопки в выбранном состоянии
        /// </summary>
        public abstract Color CheckedBackColor { get; set; }

        internal void BaseCodeButton_Disposed(object sender, EventArgs e) {
            ((ICodeButton)this).UnregisterControl();
        }
    }
}
