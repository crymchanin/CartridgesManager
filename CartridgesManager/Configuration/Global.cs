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
        /// Параметры подключения к БД
        /// </summary>
        [DataMember]
        public Sql Sql { get; set; }
    }
}
