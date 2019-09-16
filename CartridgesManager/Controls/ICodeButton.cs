using System;
using System.ComponentModel;


namespace CartridgesManager.Controls {
    public interface ICodeButton {
        /// <summary>
        /// Происходит завершении чтения штрихкода
        /// </summary>
        event EventHandler ButtonClick;

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
        [Category("Appearance")]
        [Description("Штрихкод кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        string Barcode { get; set; }
    }
}
