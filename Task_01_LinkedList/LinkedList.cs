using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_LinkedList
{
    
    public class LinkedList<T> :ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, ISerializable, IDeserializationCallback
    {
        readonly T[] elements = new T[0];
        readonly object syncRoot = new object();

        /// <summary>
        /// Первый элемент списка
        /// </summary>
        private LinkedListNode<T> head = null;

        /// <summary>
        /// Хвостовой элемент списка
        /// </summary>
        private LinkedListNode<T> tail = null;

        /// <summary>
        /// кол-во элементов списка
        /// </summary>
        private int count = 0;
       
        #region ICollection
        public int Count => count;//or elements.Length??????
        public object SyncRoot => syncRoot;

        public bool IsSynchronized => true;

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }        
        #endregion

        #region ICollection<T>

        public bool IsReadOnly => false;
        public void Add(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            // Создаем новый элемент связного списка.
            var item = new LinkedListNode<T>(value);

            // Если связный список пуст, то добавляем созданный элемент в начало,
            // иначе добавляем этот элемент как следующий за крайним элементом.
            if (head == null)
            {
                head = item;
            }
            else
            {
                tail.Next = item;
            }

            // Устанавливаем этот элемент последним.
            tail = item;

            // Увеличиваем счетчик количества элементов.
            count++;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T value)
        {
            foreach(var element in elements)
            {
                if (element.Equals(value))
                    return true;
            }

            return false;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region

        /// <summary>
        /// Вернуть перечислитель, который осуществляет итерационный переход по связному списку
        /// </summary>
        /// <returns>Объект IEnumerator, который используется для прохода по коллекции</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            //Возвращаем перечислитель
            //что бы была возможность перебирать элементы связного списка операций foreach
            return ((IEnumerable)this).GetEnumerator();
        }
        #endregion

        #region IEnumerable<T>

        /// <summary>
        /// Вернуть перечислитель, выполняющий перебор всех элементов в связном списке
        /// </summary>
        /// <returns>Перечислитель, который можно использовать для итерации по коллекции</returns>
        public IEnumerator<T> GetEnumerator()
        {
            //Перебираем все элементы связного списка, для представления в виде коллекции элементов
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISerializable
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IDeserializationCallback
        public void OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// Удалить данные из связного списка.
        /// Выполняется удаление первого вхождения данных.
        /// </summary>
        /// <param name="data"> Данные, которые будут удалены. </param>
        public void Delete(T value)
        {
            // Не забываем проверять входные аргументы на null.
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            // Текущий обозреваемый элемент списка.
            var current = head;

            // Предыдущий элемент списка, перед обозреваемым.
            LinkedListNode<T> previous = null;

            // Выполняем переход по всех элементам списка до его завершения,
            // или пока не будет найден элемент, который необходимо удалить.
            while (current != null)
            {
                // Если данные обозреваемого элемента совпадают с удаляемыми данными,
                // то выполняем удаление текущего элемента учитывая его положение в цепочке.
                if (current.Value.Equals(value))
                {
                    // Если элемент находится в середине или в конце списка,
                    // выкидываем текущий элемент из списка.
                    // Иначе это первый элемент списка,
                    // выкидываем первый элемент из списка.
                    if (previous != null)
                    {
                        // Устанавливаем у предыдущего элемента указатель на следующий элемент от текущего.
                        previous.Next = current.Next;

                        // Если это был последний элемент списка, 
                        // то изменяем указатель на крайний элемент списка.
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        // Устанавливаем головной элемент следующим.
                        head = head.Next;

                        // Если список оказался пустым,
                        // то обнуляем и крайний элемент.
                        if (head == null)
                        {
                            tail = null;
                        }
                    }

                    // Элемент был удален.
                    // Уменьшаем количество элементов и выходим из цикла.
                    // Для того, чтобы удалить все вхождения данных из списка
                    // необходимо не выходить из цикла, а продолжать до его завершения.
                    count--;
                    break;
                }

                // Переходим к следующему элементу списка.
                previous = current;
                current = current.Next;
            }
        }
    }
}
