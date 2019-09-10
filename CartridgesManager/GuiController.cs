using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace CartridgesManager {
    public static class GuiController {

        public const long START_RANGE = 99000000000000;
        public const long END_RANGE =   99999999999999;

        /// <summary>
        /// Включен или отключен полноэкранный режим
        /// </summary>
        private static bool IsFullScreen { get; set; }

        /// <summary>
        /// Служебный параметр
        /// </summary>
        private static FormWindowState OldState { get; set; } = FormWindowState.Normal;

        private static Dictionary<string, Control> ControlsDictionary { get; set; } = new Dictionary<string, Control>();
        private static Dictionary<string, ControlCallback> ControlsCallbacks { get; set; } = new Dictionary<string, ControlCallback>();

        public delegate void ControlCallback();

        /// <summary>
        /// Возвращает или задает состояние доступности выполнения основных действий программы
        /// </summary>
        public static bool IsMainActionsAllowed { get; set; } = true;

        /// <summary>
        /// Ссылка на экхемпляр главной формы приложения
        /// </summary>
        public static MainForm MainForm { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static long GenerateCode() {
            Random random = new Random();
            long code = START_RANGE + random.Next(1, 999999999);

            return code;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private static string GetCode(Control control) {
            return ControlsDictionary.FirstOrDefault(x => x.Value.GetHashCode() == control.GetHashCode()).Key;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static string RegisterControl(this Control control, ControlCallback callback) {
            string strCode = GenerateCode().ToString();
            while (ControlsDictionary.ContainsKey(strCode)) {
                strCode = GenerateCode().ToString();
            }
            ControlsDictionary.Add(strCode, control);
            ControlsCallbacks.Add(strCode, callback);

            return strCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        public static void UnregisterControl(this Control control) {
            string code = GetCode(control);
            if (string.IsNullOrEmpty(code)) {
                ControlsDictionary.Remove(code);
                ControlsCallbacks.Remove(code);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Control GetAssociatedControl(string code) {
            if (!ControlsDictionary.ContainsKey(code)) {
                throw new ArgumentException("Элемент с кодом '" + code + "' не зарегистрирован");
            }

            return ControlsDictionary[code];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        public static void InvokeAssociatedCallback(string code) {
            if (!ControlsCallbacks.ContainsKey(code)) {
                throw new ArgumentException("Функция обратного вызова с кодом '" + code + "' не зарегестрирована");
            }

            ControlsCallbacks[code]?.Invoke();
        }

        /// <summary>
        /// Закрывает текущую страницу и переходит на главную
        /// </summary>
        /// <param name="control"></param>
        public static void NavigateToMainPage(this Control control) {
            IsMainActionsAllowed = true;
            MainForm.Controls.Remove(control);
            if (!control.IsDisposed) {
                control.Dispose();
            }
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

        /// <summary>
        /// Выполняет выход из данного приложения
        /// </summary>
        public static void ExitApplication() {
            Application.Exit();
        }
    }
}
