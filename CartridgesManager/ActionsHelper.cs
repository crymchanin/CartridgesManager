using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/// <summary>
/// Управляющие перечисления программы
/// </summary>
namespace CartridgesManager {
    public static class ActionsHelper {

        /// <summary>
        /// Включен или отключен полноэкранный режим
        /// </summary>
        private static bool IsFullScreen { get; set; }

        /// <summary>
        /// Служебный параметр
        /// </summary>
        private static FormWindowState OldState { get; set; } = FormWindowState.Normal;


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
        /// Действия с GUI приложения
        /// </summary>
        public enum GuiActions : long {
            /// <summary>
            /// Кнопка закрытия
            /// </summary>
            CloseButton = 99000000000001
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
            Type type = Assembly.GetExecutingAssembly().GetTypes().
                Where(t => t.IsEnum && Enum.IsDefined(t, code)).FirstOrDefault();

            return type;
        }

        /// <summary>
        /// Выполняет выход из данного приложения
        /// </summary>
        public static void ExitApplication() {
            Application.Exit();
        }

        /// <summary>
        /// Включает либо выключает полноэкранный режим
        /// </summary>
        /// <param name="form"></param>
        public static void SwitchFullScreenMode(this MainForm form) {
            if (!IsFullScreen) {
                OldState = form.WindowState;
                form.WindowState = FormWindowState.Normal;
            }
            IsFullScreen = !IsFullScreen;

            form.FormBorderStyle = (IsFullScreen) ? FormBorderStyle.None : FormBorderStyle.FixedSingle;
            form.WindowState = (IsFullScreen) ? FormWindowState.Maximized : OldState;
        }
    }
}
