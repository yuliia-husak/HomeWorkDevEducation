using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBasedQueue
{
    public class MyQeque<T>
    {
        LinkedList<T> _items = new LinkedList<T>();       

        public void Enqueue(T value)
        {
            _items.AddLast(value);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста");
            }

            T temp = _items.First.Value;
            _items.RemoveFirst();

            return temp;
        }
       
        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста");
            }

            return _items.First.Value;
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public void Show()
        {
            foreach (var i in _items)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
