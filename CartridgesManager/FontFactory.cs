using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;


namespace CartridgesManager {
    /// <summary>
    /// Класс предоставляющий методы для работы со шрифтами
    /// </summary>
    public static class FontFactory {

        private static PrivateFontCollection _privateFontCollection = new PrivateFontCollection();

        /// <summary>
        /// Возвращает семейство шрифтов по его имени из коллекции
        /// </summary>
        /// <param name="name">Имя семейства шрифта</param>
        /// <returns></returns>
        public static FontFamily GetFontFamilyByName(string name) {
            return _privateFontCollection.Families.FirstOrDefault(x => x.Name == name);
        }

        /// <summary>
        /// Добавляет шрифт в коллекцию семейств шрифтов
        /// </summary>
        /// <param name="fullFileName">Полный путь к файлу шрифта</param>
        public static void AddFont(string fullFileName) {
            AddFont(File.ReadAllBytes(fullFileName));
        }

        /// <summary>
        /// Добавляет шрифт в коллекцию семейств шрифтов
        /// </summary>
        /// <param name="fontBytes">Массив байт содержащий двоичные данные шрифта</param>
        public static void AddFont(byte[] fontBytes) {
            GCHandle handle = GCHandle.Alloc(fontBytes, GCHandleType.Pinned);
            IntPtr pointer = handle.AddrOfPinnedObject();
            try {
                _privateFontCollection.AddMemoryFont(pointer, fontBytes.Length);
            }
            finally {
                handle.Free();
            }
        }
    }
}
