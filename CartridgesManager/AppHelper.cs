using CartridgesManager.Configuration;
using Feodosiya.Lib.Conf;
using Feodosiya.Lib.IO;
using Feodosiya.Lib.Logs;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace CartridgesManager {
    public static class AppHelper {
        /// <summary>
        /// Рабочий каталог
        /// </summary>
        public static string CurrentDirectory { get; set; }

        /// <summary>
        /// Имя текущего приложения
        /// </summary>
        public static string ProductName { get; set; }

        /// <summary>
        /// Менеджер концигурации
        /// </summary>
        public static ConfHelper ConfHelper { get; set; }

        /// <summary>
        /// Конфигурация программы
        /// </summary>
        public static Global Configuration { get; set; }

        /// <summary>
        /// Лог файл
        /// </summary>
        public static Log Log { get; set; }

        /// <summary>
        /// Штрихкод
        /// </summary>
        public static string Barcode { get; set; } = string.Empty;


        /// <summary>
        /// Создает сообщение, которое можно записать в лог, вывести в окне и отправить по почте
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="messageType">Тип сообщения</param>
        /// <param name="showMessageBox">Отображает окно сообщения если установлено в true</param>
        public static void CreateMessage(string message, MessageType messageType, bool showMessageBox = false) {
            if (messageType == MessageType.Debug) {
                if (Configuration != null) {
                    if (!Configuration.DebuggingEnabled) {
                        return;
                    }
                }
            }
            Log.Write(message, messageType);

            // Отображает окно сообщения с заданным текстом если true
            if (showMessageBox) {
                MessageBoxIcon msgBoxIcon;
                string msgBoxTitle;
                switch (messageType) {
                    case MessageType.Debug:
                        msgBoxIcon = MessageBoxIcon.Information;
                        msgBoxTitle = "Отладка";
                        break;
                    case MessageType.Error:
                        msgBoxIcon = MessageBoxIcon.Error;
                        msgBoxTitle = "Ошибка";
                        break;
                    case MessageType.Information:
                        msgBoxIcon = MessageBoxIcon.Information;
                        msgBoxTitle = "Информация";
                        break;
                    case MessageType.Warning:
                        msgBoxIcon = MessageBoxIcon.Warning;
                        msgBoxTitle = "Внимание";
                        break;
                    case MessageType.None:
                    default:
                        msgBoxIcon = MessageBoxIcon.None;
                        msgBoxTitle = "Сообщение";
                        break;
                }
                MessageBox.Show(message, msgBoxTitle, MessageBoxButtons.OK, msgBoxIcon);
            }
        }

        /// <summary>
        /// Инициализация приложения
        /// </summary>
        public static bool Init() {
            try {
                Assembly assembly = Assembly.GetExecutingAssembly();
                CurrentDirectory = IOHelper.GetCurrentDir(assembly);
                ProductName = FileVersionInfo.GetVersionInfo(assembly.Location).ProductName;

                Log = new Log(Path.Combine(CurrentDirectory, ProductName + ".log")) { InsertDate = true, AutoCompress = true };
                Log.ExceptionThrownEvent += (e) => MessageBox.Show(e.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при инициализации программы. Текст ошибки:\r\n" + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Инициализация конфигурации приложения
        /// </summary>
        /// <returns></returns>
        public static bool InitConfiguration() {
            try {
                string confPath = Path.Combine(CurrentDirectory, "settings.conf");
                ConfHelper = new ConfHelper(confPath);
                if (!File.Exists(confPath)) {
                    Global gl = new Global();
                    gl.Sql = new Sql();
                    ConfHelper.SaveConfig(gl, Encoding.UTF8, true);
                    CreateMessage("Файл конфигурации приложения не был обнаружен. Создан файл конфигурации с параметрами по умолчанию.", MessageType.Warning, true);
                }
                Configuration = ConfHelper.LoadConfig<Global>();
                if (!ConfHelper.Success) {
                    CreateMessage("Ошибка при загрузке конфигурации:\r\n" + ConfHelper.LastError.ToString(), MessageType.Error, true);
                    return false;
                }

                return true;
            }
            catch (Exception ex) {
                CreateMessage("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(), MessageType.Error, true);
                return false;
            }
        }
    }
}
