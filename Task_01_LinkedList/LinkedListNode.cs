using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_LinkedList
{
    public class LinkedListNode<T>
    {
        private object newElement;

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {

            //проверка входного аргумента на null
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        public LinkedListNode(object newElement)
        {
            this.newElement = newElement;
        }

        public LinkedListNode<T>  Previous { get; set; }

        /// <summary>
        /// Приведение объекта к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
