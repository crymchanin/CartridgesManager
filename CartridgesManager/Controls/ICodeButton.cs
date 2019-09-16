namespace CartridgesManager.Controls {
    public interface ICodeButton {

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
    }
}
