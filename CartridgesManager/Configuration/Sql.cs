using System.Runtime.Serialization;


namespace CartridgesManager.Configuration {
    /// <summary>
    /// Параметры подключения к БД
    /// </summary>
    [DataContract]
    public class Sql {
        /// <summary>
        /// Путь к БД
        /// </summary>
        [DataMember]
        public string DataSource { get; set; }

        /// <summary>
        /// Имя пользователя на сервере
        /// </summary>
        [DataMember]
        public string UserID { get; set; }

        /// <summary>
        /// Пароль к серверу
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Драйвер
        /// </summary>
        [DataMember]
        public string Provider { get; set; }

        [OnDeserialized]
        public void OnDeserialized(StreamingContext ctx) {
            UserID = (string.IsNullOrEmpty(UserID)) ? "Admin" : UserID;
            Provider = (string.IsNullOrEmpty(Provider)) ? "Microsoft.ACE.OLEDB.12.0" : Provider;
        }
    }
}
