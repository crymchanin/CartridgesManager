using System;
using System.Linq;
using System.Reflection;


namespace CartridgesManager {
    public static class ActionsHelper {

        /// <summary>
        /// Основные действия в программе
        /// </summary>
        public enum MainActions : long {
            /// <summary>
            /// Информация о картридже
            /// </summary>
            CartridgeInfo = 90000000000001,
            /// <summary>
            /// Добавить новый картридж
            /// </summary>
            AddNewCartridge = 90000000000002,
            /// <summary>
            /// Обслуживание картриджа
            /// </summary>
            ServiceCartridge = 90000000000003,
            /// <summary>
            /// Просмотр картриджей отделения
            /// </summary>
            PostOfficeInfo = 90000000000004,
            /// <summary>
            /// Открыть смену
            /// </summary>
            NewSession = 91000000000001,
            /// <summary>
            /// Закрыть смену
            /// </summary>
            CloseSession = 91000000000002,
            /// <summary>
            /// Полноэкранный режим
            /// </summary>
            FullScreen = 92000000000001,
            /// <summary>
            /// Выйти из приложения
            /// </summary>
            ExitApplication = 92000000000002
        }

        /// <summary>
        /// Проверяет код на принадлежнойсть к сервисным кодам
        /// </summary>
        /// <param name="code">Проверяемый код</param>
        /// <returns></returns>
        public static bool IsServiceCode(long code) {
            return GetCodeType(code) != null;
        }

        /// <summary>
        /// Определяет тип перечесления к которому относится код
        /// </summary>
        /// <param name="code">Проверяемый код</param>
        /// <returns></returns>
        public static Type GetCodeType(long code) {
            Type thisType = typeof(ActionsHelper);
            Type type = thisType.GetNestedTypes().
                Where(t => t.IsEnum && Enum.IsDefined(t, code)).FirstOrDefault();

            return type;
        }
    }
}
