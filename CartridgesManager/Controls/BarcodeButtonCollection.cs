using System.Collections;
using System.Collections.Generic;


namespace CartridgesManager.Controls {
    public class CodeButtonCollection : IList<BaseCodeButton>, ICollection<BaseCodeButton>, IEnumerable<BaseCodeButton> {

        private ArrayList _buttonList = new ArrayList();

        /// <summary>
        /// Возвращает или задает элемент по указанному индексу
        /// </summary>
        /// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
        /// <returns>Элемент, расположенный по указанному индексу</returns>
        public BaseCodeButton this[int index] { get => (BaseCodeButton)_buttonList[index]; set => _buttonList[index] = value; }

        /// <summary>
        /// Возвращает число элементов, содержащихся в CodeButtonCollection
        /// </summary>
        public int Count => _buttonList.Count;

        /// <summary>
        /// Получает значение, указывающее, является ли объект CodeButtonCollection доступным только для чтения
        /// </summary>
        public bool IsReadOnly => _buttonList.IsReadOnly;

        /// <summary>
        /// Добавляет объект в конец очереди CodeButtonCollection
        /// </summary>
        /// <param name="item">Объект BaseCodeButton, добавляемый в конец коллекции CodeButtonCollection. Допускается значение null</param>
        public void Add(BaseCodeButton item) {
            _buttonList.Add(item);
        }

        /// <summary>
        /// Удаляет все элементы из коллекции CodeButtonCollection
        /// </summary>
        public void Clear() {
            _buttonList.Clear();
        }

        /// <summary>
        /// Определяет, входит ли элемент в коллекцию CodeButtonCollection
        /// </summary>
        /// <param name="item">Объект BaseCodeButton, который требуется найти в коллекции CodeButtonCollection. Допускается значение null</param>
        /// <returns></returns>
        public bool Contains(BaseCodeButton item) {
            return _buttonList.Contains(item);
        }

        /// <summary>
        /// Копирует целый массив CodeButtonCollection в совместимый одномерный массив CodeButtonCollection, начиная с заданного индекса целевого массива
        /// </summary>
        /// <param name="array">Одномерный массив CodeButtonCollection, в который копируются элементы из интерфейса . Массив CodeButtonCollection должен иметь индексацию, начинающуюся с нуля</param>
        /// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве array, указывающий начало копирования</param>
        public void CopyTo(BaseCodeButton[] array, int arrayIndex) {
            _buttonList.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Возвращает перечислитель для всего CodeButtonCollection
        /// </summary>
        /// <returns>System.Collections.IEnumerator Для всего CodeButtonCollection</returns>
        public IEnumerator<BaseCodeButton> GetEnumerator() {
            return (IEnumerator<BaseCodeButton>)((IEnumerable)this).GetEnumerator();
        }

        /// <summary>
        /// Осуществляет поиск указанного объекта BaseCodeButton и возвращает отсчитываемый от нуля индекс первого вхождения в коллекцию CodeButtonCollection
        /// </summary>
        /// <param name="item">Объект BaseCodeButton, который требуется найти в коллекции CodeButtonCollection</param>
        /// <returns>Индекс (с нуля) первого вхождения параметра item, если оно найдено в коллекции CodeButtonCollection; в противном случае -1</returns>
        public int IndexOf(BaseCodeButton item) {
            return _buttonList.IndexOf(item);
        }

        /// <summary>
        /// Вставляет элемент в коллекцию CodeButtonCollection по указанному индексу
        /// </summary>
        /// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент item</param>
        /// <param name="item">Вставляемый объект BaseCodeButton. Допускается значение null</param>
        public void Insert(int index, BaseCodeButton item) {
            _buttonList.Insert(index, item);
        }

        /// <summary>
        /// Удаляет первое вхождение указанного объекта из коллекции CodeButtonCollection
        /// </summary>
        /// <param name="item">Элемент BaseCodeButton, который требуется удалить из CodeButtonCollection</param>
        /// <returns></returns>
        public bool Remove(BaseCodeButton item) {
            int index = IndexOf(item);
            if (index >= 0) {
                _buttonList.RemoveAt(index);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Удаляет элемент списка CodeButtonCollection с указанным индексом
        /// </summary>
        /// <param name="index">Индекс (с нуля) элемента, который требуется удалить</param>
        public void RemoveAt(int index) {
            _buttonList.RemoveAt(index);
        }

        /// <summary>
        /// Возвращает перечислитель для всего CodeButtonCollection
        /// </summary>
        /// <returns>System.Collections.IEnumerator Для всего CodeButtonCollection</returns>
        IEnumerator IEnumerable.GetEnumerator() {
            return _buttonList.GetEnumerator();
        }
    }
}
