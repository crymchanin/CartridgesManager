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
        public List<string> Users { get; set; }

        /// <summary>
        /// Параметры подключения к БД
        /// </summary>
        [DataMember]
        public Sql Sql { get; set; }


        [OnDeserialized]
        public void OnDeserialized(StreamingContext ctx) {
            if (Users == null) {
                Users = new List<string>();
            }
        }
    }
}
