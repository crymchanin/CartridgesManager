using System.Text;


namespace CartridgesManager {
    /// <summary>
    /// Класс предоставляющий методы для управления сменой
    /// </summary>
    public static class SessionManager {
        /// <summary>
        /// Имя пользователя открывшего смену
        /// </summary>
        public static string WorkerName { get; private set; }

        /// <summary>
        /// Возвращает значение определяющее открыта или закрыта смена
        /// </summary>
        public static bool IsSessionCreated { get; private set; }

        /// <summary>
        /// Открывает новую смену
        /// </summary>
        /// <param name="workerName">Имя пользователя открывающего смену</param>
        public static bool CreateNewSession(string workerName) {
            if (!AppHelper.Configuration.Users.Contains(workerName)) {
                return false;
            }
            WorkerName = workerName;
            IsSessionCreated = true;
            SaveToConfig();

            return true;
        }

        /// <summary>
        /// Закрывает смену
        /// </summary>
        public static void CloseSession() {
            WorkerName = null;
            IsSessionCreated = false;
            SaveToConfig();
        }

        /// <summary>
        /// Сохраняет информацию об открытии/закрытии смены в конфиг
        /// </summary>
        private static void SaveToConfig() {
            AppHelper.Configuration.SessionUserName = WorkerName;
            AppHelper.ConfHelper.SaveConfig(AppHelper.Configuration, Encoding.UTF8, true);
        }
    }
}
