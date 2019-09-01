using System;


namespace CartridgesManager {
    /// <summary>
    /// 
    /// </summary>
    public class ServiceOperation {
        /// <summary>
        /// Дата выполнения обслуживания
        /// </summary>
        public DateTime OperationDate { get; set; }

        /// <summary>
        /// Тип выполненной работы
        /// </summary>
        public string OperationType{ get; set; }

        /// <summary>
        /// Наименование использованной комплектующей
        /// </summary>
        public string PartName { get; set; }

        /// <summary>
        /// Количество использованных комплектующих
        /// </summary>
        public int PartsCount { get; set; }

        /// <summary>
        /// Фамилия выполневшего обслуживание
        /// </summary>
        public string WorkerLastName { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="operationDate">Дата выполнения обслуживания</param>
        /// <param name="operationType">Тип выполненной работы</param>
        /// <param name="partName">Наименование использованной комплектующей</param>
        /// <param name="partsCount">Количество использованных комплектующих</param>
        /// <param name="workerLastName">Фамилия выполневшего обслуживание</param>
        /// <param name="comment">Комментарий</param>
        public ServiceOperation(DateTime operationDate, string operationType, string partName,
            int partsCount, string workerLastName, string comment) {
            OperationDate = operationDate;
            OperationType = operationType;
            PartName = partName;
            PartsCount = partsCount;
            WorkerLastName = workerLastName;
            Comment = comment;
        }
    }
}
