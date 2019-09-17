using CartridgesManager.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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

        private static Dictionary<string, ICodeButton> ControlsDictionary { get; set; } = new Dictionary<string, ICodeButton>();
        private static Dictionary<string, ControlCallback> ControlsCallbacks { get; set; } = new Dictionary<string, ControlCallback>();

        public delegate void ControlCallback(string code);


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
        private static string GetCode(ICodeButton control) {
            return ControlsDictionary.FirstOrDefault(x => x.Value.GetHashCode() == control.GetHashCode()).Key;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static string RegisterControl(this ICodeButton control, ControlCallback callback) {
            string strCode = GenerateCode().ToString();
            long counter = 0;
            while (ControlsDictionary.ContainsKey(strCode)) {
                if (counter >= END_RANGE) {
                    break;
                }
                strCode = GenerateCode().ToString();
                counter++;
            }
            ControlsDictionary.Add(strCode, control);
            ControlsCallbacks.Add(strCode, callback);
            (control as ICodeButton).ButtonClick += (s, e) =>
                callback.Invoke(strCode);
            ;

            return strCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="code"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static string RegisterControl(this ICodeButton control, long code, ControlCallback callback) {
            string strCode = code.ToString();
            if (ControlsDictionary.ContainsKey(strCode)) {
                throw new ArgumentException("Элемент с кодом '" + strCode + "' уже зарегистрирован");
            }

            ControlsDictionary.Add(strCode, control);
            ControlsCallbacks.Add(strCode, callback);
            (control as ICodeButton).ButtonClick += (s, e) =>
                callback.Invoke(strCode);
            ;

            return strCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        public static void UnregisterControl(this ICodeButton control) {
            string code = GetCode(control);
            if (!string.IsNullOrEmpty(code)) {
                ControlsDictionary.Remove(code);
                ControlsCallbacks.Remove(code);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static ICodeButton GetAssociatedControl(string code) {
            if (!ControlsDictionary.ContainsKey(code)) {
                throw new ArgumentException("Элемент с кодом '" + code + "' не зарегистрирован");
            }

            return ControlsDictionary[code];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="args"></param>
        public static void InvokeAssociatedCallback(string code) {
            if (!ControlsCallbacks.ContainsKey(code)) {
                throw new ArgumentException("Функция обратного вызова с кодом '" + code + "' не зарегестрирована");
            }

            ControlsCallbacks[code]?.Invoke(code);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        public static void ShowThisPage(this Control control) {
            control.Dock = DockStyle.Fill;
            MainForm.Controls.Add(control);
            control.BringToFront();
            control.Focus();
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
        /// Отображает сообщение в строке состояния формы
        /// </summary>
        /// <param name="message">Выводимое сообщение</param>
        /// <param name="isError">Тип сообщения - ошибка или простое</param>
        public static void CreateMessage(string message, bool isError) {
            MainForm.CurrentOperationStripLabel.ForeColor = (isError) ? Color.Red : Color.Green;
            MainForm.CurrentOperationStripLabel.Text = message;
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

            form.FormBorderStyle = (IsFullScreen) ? FormBorderStyle.None : FormBorderStyle.Sizable;
            form.WindowState = (IsFullScreen) ? FormWindowState.Maximized : OldState;
            if (!IsFullScreen) {
                form.SetDesktopLocation(Screen.PrimaryScreen.Bounds.Location.X + (Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2,
                    Screen.PrimaryScreen.Bounds.Location.Y + (Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2);
            }
        }

        /// <summary>
        /// Выполняет выход из данного приложения
        /// </summary>
        public static void ExitApplication() {
            Application.Exit();
        }

        /// <summary>
        /// Изменяет размер изображения на указанные высоту и ширину
        /// </summary>
        /// <param name="image">Изменяемое изображение</param>
        /// <param name="width">Новая ширина</param>
        /// <param name="height">Новая высота</param>
        /// <returns>Измененное изображение</returns>
        public static Bitmap ResizeImage(Image image, int width, int height) {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
