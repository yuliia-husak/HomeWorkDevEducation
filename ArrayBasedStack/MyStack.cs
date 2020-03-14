using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedStack
{
    class MyStack<T>
    {
        T[] mas = new T[0];

        int top = -1;

        //public int Count { get { return mas.Length; } }

        int size = 0;

        public void Push(T value)
        {
            if (mas.Length == size)
            {
                createNewArray(1);
            }

            if (top == mas.Length - 1)
            {
                top = 0;
            }

            else
            {
                top++;
            }
            mas[top] = value;
            size++;
        }

        private void createNewArray(int v)
        {
            int newLength = (size == 0) ? 4 : size * 2;
            T[] newArray = new T[newLength];
            if (size > 0)
            {
                for (int i = 0; i < mas.Length; i++) 
                {
                    newArray[i] = mas[i];
                }
                
            }
            mas = newArray;
        }

        public T Pop()
        {
            if (mas.Length == 0)
            {
                throw new InvalidOperationException("This stack is empty");
            }

            T result = mas[top];
            T[] newArray = new T[mas.Length-1];
            if (size > 0)
            {
                for (int i = 0; i < mas.Length-1; i++)
                {
                    newArray[i] = mas[i];
                }

            }
            mas = newArray;
            top--;
            size--;
            return result;
        }

        public T Peek()
        {
            if (mas.Length == 0)
            {
                throw new InvalidOperationException("This stack is empty");
            }

            return mas[top];
        }

        public void ShowStack() 
        {
            if (mas.Length == 0)
            {
                Console.WriteLine("This stack is empty");
            }
            else
            {
                for(int i = mas.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(mas[i]);
                }
            }
            
        }

    }
}
