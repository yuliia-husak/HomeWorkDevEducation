using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0111_SimpleListFullMenthod
{
    public class SimpleListNode<T> : IEnumerable<T>
    {
        public Node<T> _head;
        public Node<T> _tail;

        public int Count { get; private set; }

        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }

        public bool Remove(T item)
        {
            Node<T> previous = null;
            Node<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item)) // Определяет, равен ли заданный объект текущему объекту.
                {

                    if (previous != null)
                    {
                        // Смена указателя Next. из  предыдущего на следующий  

                        // ДО:
                        // head
                        // +-----+------+    +-----+------+    +-----+-----+    +-----+-----+
                        // | 12  |  *---+--->| 15  |   *--+--->| 20  |  *--+--->| 25  |  *--+--->
                        // +-----+------+    +-----+------+    +-----+-----+    +-----+-----+

                        previous.Next = current.Next;

                        // ПОСЛЕ:
                        // head
                        // +-----+------+    +-----+------+                     +-----+-----+
                        // | 12  |  *---+--->| 15  |   *--+-------------------->| 25  |  *--+--->
                        // +-----+------+    +-----+------+                     +-----+-----+

                        // Определение конца списка

                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // Удаление первого элемента списка

                        _head = _head.Next;

                        // Если список пуст и был удален единственный элемент                 

                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public bool Contains(T item)
        {
            Node<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            // Метод Clear очищет список, устанавливая _head и _tail в null. Достаточно удалить ссылки на элементы и сборщик мусора,
            // самостоятельно сотрет список.

            _head = null;
            _tail = null;
            Count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> current = _head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
