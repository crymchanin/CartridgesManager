using System.Runtime.Serialization;


namespace CartridgesManager.Configuration {
    /// <summary>
    /// Параметры сканера штрихкодов
    /// </summary>
    [DataContract]
    public class BarcodeScanner {
        /// <summary>
        /// Номер последовательного порта (например COM1)
        /// </summary>
        [DataMember]
        public string ComPort { get; set; }

        /// <summary>
        /// Скорость передачи для последовательного порта в (бодах)
        /// </summary>
        [DataMember]
        public int BaudRate { get; set; }

        [OnDeserialized]
        public void OnDeserialized(StreamingContext ctx) {
            ComPort = (string.IsNullOrEmpty(ComPort)) ? "COM1" : ComPort;
            BaudRate = (BaudRate < 9600) ? 9600 : BaudRate;
        }
    }
}
