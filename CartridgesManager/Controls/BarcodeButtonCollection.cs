using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CartridgesManager.Controls {
    public class BarcodeButtonCollection : IList<BarcodeButton>, ICollection<BarcodeButton>, IEnumerable<BarcodeButton> {

        private ArrayList _buttonList = new ArrayList();

        /// <summary>
        /// Возвращает или задает элемент по указанному индексу
        /// </summary>
        /// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
        /// <returns>Элемент, расположенный по указанному индексу</returns>
        public BarcodeButton this[int index] { get => (BarcodeButton)_buttonList[index]; set => _buttonList[index] = value; }

        /// <summary>
        /// Возвращает число элементов, содержащихся в BarcodeButtonCollection
        /// </summary>
        public int Count => _buttonList.Count;

        /// <summary>
        /// Получает значение, указывающее, является ли объект BarcodeButtonCollection доступным только для чтения
        /// </summary>
        public bool IsReadOnly => _buttonList.IsReadOnly;

        /// <summary>
        /// Добавляет объект в конец очереди BarcodeButtonCollection
        /// </summary>
        /// <param name="item">Объект BarcodeButton, добавляемый в конец коллекции BarcodeButtonCollection. Допускается значение null</param>
        public void Add(BarcodeButton item) {
            _buttonList.Add(item);
        }

        /// <summary>
        /// Удаляет все элементы из коллекции BarcodeButtonCollection
        /// </summary>
        public void Clear() {
            _buttonList.Clear();
        }

        /// <summary>
        /// Определяет, входит ли элемент в коллекцию BarcodeButtonCollection
        /// </summary>
        /// <param name="item">Объект BarcodeButton, который требуется найти в коллекции BarcodeButtonCollection. Допускается значение null</param>
        /// <returns></returns>
        public bool Contains(BarcodeButton item) {
            return _buttonList.Contains(item);
        }

        /// <summary>
        /// Копирует целый массив BarcodeButtonCollection в совместимый одномерный массив BarcodeButtonCollection, начиная с заданного индекса целевого массива
        /// </summary>
        /// <param name="array">Одномерный массив BarcodeButtonCollection, в который копируются элементы из интерфейса . Массив BarcodeButtonCollection должен иметь индексацию, начинающуюся с нуля</param>
        /// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве array, указывающий начало копирования</param>
        public void CopyTo(BarcodeButton[] array, int arrayIndex) {
            _buttonList.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Возвращает перечислитель для всего BarcodeButtonCollection
        /// </summary>
        /// <returns>System.Collections.IEnumerator Для всего BarcodeButtonCollection</returns>
        public IEnumerator<BarcodeButton> GetEnumerator() {
            return (IEnumerator<BarcodeButton>)((IEnumerable)this).GetEnumerator();
        }

        /// <summary>
        /// Осуществляет поиск указанного объекта BarcodeButton и возвращает отсчитываемый от нуля индекс первого вхождения в коллекцию BarcodeButtonCollection
        /// </summary>
        /// <param name="item">Объект BarcodeButton, который требуется найти в коллекции BarcodeButtonCollection</param>
        /// <returns>Индекс (с нуля) первого вхождения параметра item, если оно найдено в коллекции BarcodeButtonCollection; в противном случае -1</returns>
        public int IndexOf(BarcodeButton item) {
            return _buttonList.IndexOf(item);
        }

        /// <summary>
        /// Вставляет элемент в коллекцию BarcodeButtonCollection по указанному индексу
        /// </summary>
        /// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент item</param>
        /// <param name="item">Вставляемый объект BarcodeButton. Допускается значение null</param>
        public void Insert(int index, BarcodeButton item) {
            _buttonList.Insert(index, item);
        }

        /// <summary>
        /// Удаляет первое вхождение указанного объекта из коллекции BarcodeButtonCollection
        /// </summary>
        /// <param name="item">Элемент BarcodeButton, который требуется удалить из BarcodeButtonCollection</param>
        /// <returns></returns>
        public bool Remove(BarcodeButton item) {
            int index = IndexOf(item);
            if (index >= 0) {
                _buttonList.RemoveAt(index);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Удаляет элемент списка BarcodeButtonCollection с указанным индексом
        /// </summary>
        /// <param name="index">Индекс (с нуля) элемента, который требуется удалить</param>
        public void RemoveAt(int index) {
            _buttonList.RemoveAt(index);
        }

        /// <summary>
        /// Возвращает перечислитель для всего BarcodeButtonCollection
        /// </summary>
        /// <returns>System.Collections.IEnumerator Для всего BarcodeButtonCollection</returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return _buttonList.GetEnumerator();
        }
    }
}
