using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Queue
{
    public class Queue<T> : IEnumerable<T>
    {
       // Queue<T> ts = new Queue<T>();

        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;

        // добавление в очередь
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }

        // удаление из очереди первого элемента
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        // удаление из очереди по позиции
        //public T DelPosition(int delX)
        //{
        //    int x = delX;      
        //    if (count == 0)
        //        throw new InvalidOperationException();
            
        //    if (x <= count)
        //    {                
        //        for (int i = 0; i < Count; i++)
        //        {
                    
        //        }
        //    }

        //    //Node<T> node = new Node<T>(data);
        //    //Node<T> tempNode = tail;
        //    //tail = node;
        //    //if (count == 0)
        //    //    head = tail;
        //    //else
        //    //    tempNode.Next = tail;
        //    //count++;

        //    //T output = head.Data;
        //    //head = head.Next;
        //    //count--;
        //    //return output;


        //    //Node<T> current = head;
        //    //while (current != null)
        //    //{
        //    //    if (current.Data.Equals(data))
        //    //        return true;
        //    //    current = current.Next;
        //    //}
        //    //return false;
        //}


        // получаем первый элемент
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
        // получаем последний элемент
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
