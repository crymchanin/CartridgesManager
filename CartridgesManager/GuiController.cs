using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CartridgesManager {
    public static class GuiController {

        public const long START_RANGE = 99000000000000;
        public const long END_RANGE =   99999999999999;

        private static Dictionary<string, Control> ControlsDictionary { get; set; } = new Dictionary<string, Control>();
        private static Dictionary<string, ControlCallback> ControlsCallbacks { get; set; } = new Dictionary<string, ControlCallback>();

        public delegate void ControlCallback();



        private static long GenerateCode() {
            Random random = new Random();
            long code = START_RANGE + random.Next(1, 999999999);

            return code;
        }

        public static string RegisterControl(this Control control, ControlCallback callback) {
            string strCode = GenerateCode().ToString();
            while (ControlsDictionary.ContainsKey(strCode)) {
                strCode = GenerateCode().ToString();
            }
            ControlsDictionary.Add(strCode, control);
            ControlsCallbacks.Add(strCode, callback);

            return strCode;
        }

        public static void UnregisterControl(this Control control, string code) {
            ControlsDictionary.Remove(code);
            ControlsCallbacks.Remove(code);
        }

        public static Control GetAssociatedControl(string code) {
            if (!ControlsDictionary.ContainsKey(code)) {
                throw new ArgumentException("Элемент с кодом '" + code + "' не зарегистрирован");
            }

            return ControlsDictionary[code];
        }

        public static void InvokeAssociatedCallback(string code) {
            if (!ControlsCallbacks.ContainsKey(code)) {
                throw new ArgumentException("Функция обратного вызова с кодом '" + code + "' не зарегестрирована");
            }

            ControlsCallbacks[code]?.Invoke();
        }
    }
}
