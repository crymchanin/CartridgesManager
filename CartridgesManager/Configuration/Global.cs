using System.Collections.Generic;
using System.Runtime.Serialization;


namespace CartridgesManager.Configuration {
    /// <summary>
    /// Параметры приложения
    /// </summary>
    [DataContract]
    public class Global {
        /// <summary>
        /// Включает или отключает режим отладки
        /// </summary>
        [DataMember]
        public bool DebuggingEnabled { get; set; }

        /// <summary>
        /// Запуск в полноэкранном или обычном режиме
        /// </summary>
        [DataMember]
        public bool RunInFullScreen { get; set; }

        /// <summary>
        /// Список пользователей
        /// </summary>
        [DataMember]
        public List<string> Users { get; set; }

        /// <summary>
        /// Имя пользователя открывшего смену
        /// </summary>
        [DataMember]
        public string SessionUserName { get; set; }

        /// <summary>
        /// Параметры подключения к БД
        /// </summary>
        [DataMember]
        public Sql Sql { get; set; }

        /// <summary>
        /// Параметры сканера штрихкодов
        /// </summary>
        [DataMember]
        public BarcodeScanner BarcodeScanner { get; set; }


        [OnDeserialized]
        public void OnDeserialized(StreamingContext ctx) {
            Users = (Users == null) ? new List<string>() : Users;
            Sql = (Sql == null) ? new Sql() : Sql;
            BarcodeScanner = (BarcodeScanner == null) ? new BarcodeScanner() : BarcodeScanner;
        }
    }
}
