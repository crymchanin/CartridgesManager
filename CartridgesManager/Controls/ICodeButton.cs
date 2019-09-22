using System;
using System.Drawing;

namespace CartridgesManager.Controls {

    /// <summary>
    /// Представляет метод, обрабатывающий событие ICodeButton.ButtonClick
    /// </summary>
    public delegate void CodeButtonClickEventHandler(ICodeButton sender, EventArgs e);


    public interface ICodeButton {

        /// <summary>
        /// Происходит нажатии кнопки
        /// </summary>
        event CodeButtonClickEventHandler ButtonClick;

        /// <summary>
        /// Возвращает пользовательские данные связанные с тукущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип возвращаемых данных</typeparam>
        /// <returns></returns>
        T GetCustomData<T>();

        /// <summary>
        /// Связывает указанные пользовательские данные с текущим элементом управления
        /// </summary>
        /// <typeparam name="T">Тип связываемых данных</typeparam>
        /// <param name="customData">Пользовательские данные</param>
        void SetCustomData<T>(T customData);

        /// <summary>
        /// Возвращает или задает штрихкод кнопки
        /// </summary>
        string Barcode { get; set; }

        /// <summary>
        /// Тип штрихкода, который будет отображен в кнопке
        /// </summary>
        CodeButtonType BarcodeType { get; }

        /// <summary>
        /// Возвращает или задает текст, связанный с этим элементом управления
        /// </summary>
        string ButtonText { get; set; }

        /// <summary>
        /// Возвращает или задает изображение, отображаемое на кнопке
        /// </summary>
        Image Image { get; set; }

        /// <summary>
        /// Возвращает или задает цвет фона элемента управления
        /// </summary>
        Color ButtonBackColor { get; set; }

        /// <summary>
        /// Возвращает или задает цвет элемента управления
        /// </summary>
        Color ButtonForeColor { get; set; }

        /// <summary>
        /// Возвращает или задает шрифт текста, отображаемого элементом управления
        /// </summary>
        Font ButtonFont { get; set; }

        /// <summary>
        /// Возвращает или задает значение отмечена ли кнопка выбранной или нет
        /// </summary>
        bool Checked { get; set; }

        /// <summary>
        /// Возвращает или задает цвет фона кнопки в выбранном состоянии
        /// </summary>
        Color CheckedBackColor { get; set; }
    }
}
