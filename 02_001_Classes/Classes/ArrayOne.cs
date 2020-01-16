using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class ArrayOne
    {
        //Поля:
        private int[] Array;
        private int n = 0;

        //Конструктор, позволяющий создать массив размерности n.
        public ArrayOne(int n)
        {
            this.n = n;
            Array = new int[n];
        }

        //Методы, позволяющие:
        //ввести элементы массива с клавиатуры;
        public void KeyboardTouch()
        {
            Console.WriteLine("Enter the elements array: ");
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
        }

        //вывести элементы массива на экран;
        public void Show()
        {
            Console.WriteLine("Array One: ");
            //for(int i = 0; i < Array.Length; i++)
            //{
            //    Console.Write($"{Array[i]} ");
            //}

            foreach (int item in Array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        //отсортировать элементы массива в порядке возрастания.
        public ArrayOne SortArray()
        {
            int temp;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return this;
        }

        //Свойства:
        //возвращающее размерность массива (доступное только для чтения);
        public string SizeArray => $"\nРазмерность массива составляет {Array.Length}";
        
        //позволяющее умножить все элементы массива на скаляр(доступное только для записи).
        public int Scalyar
        {            
            set
            {
                for(int i = 0; i < Array.Length; i++)
                {
                    Array[i] *= value;
                }
            }
        }

    }
}
