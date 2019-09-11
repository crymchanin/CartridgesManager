using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace CartridgesManager {

    public static class DatabaseHelper {

        /// <summary>
        /// Возвращает информацию о картридже
        /// </summary>
        /// <param name="code">Код картриджа</param>
        public static CartridgeInfo GetCartridgeInfo(long code) {
            string connectionString = string.Format(@"Provider={0}; Data Source={1}; User ID={2}; Password={3}",
                AppHelper.Configuration.Sql.Provider, AppHelper.Configuration.Sql.DataSource, AppHelper.Configuration.Sql.UserID, AppHelper.Configuration.Sql.Password);

            using (OleDbConnection connection = new OleDbConnection(connectionString)) {
                connection.Open();

                string queryString = @"SELECT Format([Дата действия], ""dd.mm.yyyy"") AS [Дата], t.[Действие] AS [Действие], a.[Название] AS [Название], [Шт], [Фамилия], [Комментарий]
                                       FROM(((SELECT o.* FROM[Действия с картриджами] AS o WHERE o.[Штрих код] IN(SELECT[Код] FROM[Картридж] WHERE[Штрих код] = '" + code.ToString() + @"')) AS r
                                       LEFT JOIN[Виды действий] AS t ON r.[Действие] = t.[Код])
                                       LEFT JOIN[Комплектующие] AS a ON r.[Название] = a.[Код])
                                       ORDER BY[Дата действия] ASC;";

                List<ServiceOperation> operations = new List<ServiceOperation>();
                using (OleDbCommand command = new OleDbCommand(queryString, connection)) {
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {
                        int count;
                        if (!int.TryParse(reader[3].ToString(), out count)) {
                            count = 0;
                        }
                        operations.Add(new ServiceOperation(DateTime.Parse(reader[0].ToString()), reader[1].ToString(),
                            reader[2].ToString(), count, reader[4].ToString(), reader[5].ToString()));
                    }
                    reader.Close();
                }

                queryString = @"SELECT Format(C.`Дата выдачи`, ""dd.mm.yyyy""), L.`Место установки`, C.`Модель картриджа`, C.`Тип картриджа`, C.`Фамилия`
                                   FROM `Картридж` AS C, `Место установки` AS L
                                   WHERE C.`Штрих код` = '" + code.ToString() + "' AND C.`Место установки` = L.`Код`";

                using (OleDbCommand command = new OleDbCommand(queryString, connection)) {
                    OleDbDataReader reader = command.ExecuteReader();

                    CartridgeInfo cartridgeInfo = null;
                    while (reader.Read()) {
                        cartridgeInfo = new CartridgeInfo(DateTime.Parse(reader[0].ToString()), reader[1].ToString(),
                            reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), operations);
                        break;
                    }
                    reader.Close();

                    return cartridgeInfo;
                }
            }
        }

        /// <summary>
        /// Возвращает типы картриджей
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetCartridgeTypes() {
            return new string[] { "б/у", "склад" };
        }

        /// <summary>
        /// Возвращает модели картриджей
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetCartridgeModels() {
            return new string[] { "Картридж  CANON 737", "Картридж HP LJ 728 /canon728", "Картридж 285А", "Картридж LJ CE278A/726/728", "Картридж MLT-D111S", "Картридж MLT-D115L" };
        }

        /// <summary>
        /// Возвращает список мест установки
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetCartridgeLocations() {
            string connectionString = string.Format(@"Provider={0}; Data Source={1}; User ID={2}; Password={3}",
                AppHelper.Configuration.Sql.Provider, AppHelper.Configuration.Sql.DataSource, AppHelper.Configuration.Sql.UserID, AppHelper.Configuration.Sql.Password);

            using (OleDbConnection connection = new OleDbConnection(connectionString)) {
                connection.Open();

                string queryString = @"SELECT `Код`, `Место установки`
                                   FROM `Место установки`
                                   ORDER BY `Место установки` ASC";

                using (OleDbCommand command = new OleDbCommand(queryString, connection)) {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read()) {
                        yield return reader[1].ToString();
                    }
                    reader.Close();
                }
            }
        }
    }
}
