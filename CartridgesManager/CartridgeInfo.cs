using System;
using System.Collections.Generic;

namespace CartridgesManager {
    public class CartridgeInfo {
        /// <summary>
        /// Дата установки
        /// </summary>
        public DateTime TransferDate { get; set; }

        /// <summary>
        /// Место установки
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Модель картриджа
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// Тип картриджа
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Фамилия выдавшего картридж
        /// </summary>
        public string InitiatorLastName { get; set; }

        /// <summary>
        /// Выполненные действия над картриджем
        /// </summary>
        public List<ServiceOperation> Operations { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public CartridgeInfo(DateTime transferDate, string location, string modelName,
            string state, string initiatorLastName, List<ServiceOperation> operations) {
            TransferDate = transferDate;
            Location = location;
            ModelName = modelName;
            State = state;
            InitiatorLastName = initiatorLastName;
            Operations = operations;
        }
    }
}
