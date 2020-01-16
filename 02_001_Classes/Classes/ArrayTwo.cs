using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class ArrayTwo
    {
        //Поля:
        private double[,] DoubleArray;
        private int n;
        private int m;

        //Конструктор, позволяющий создать массив размерности n×m.
        public ArrayTwo(int n, int m)
        {
            this.n = n;
            this.m = m;
            DoubleArray = new double[n,m];
        }

        //Методы, позволяющие:
        //ввести элементы массива с клавиатуры;
        public void KeyboardArray()
        {
            for(int i = 0; i < DoubleArray.GetLength(0); i++, Console.WriteLine())
            {
                for(int j = 0; j < DoubleArray.GetLength(1); j++)
                {
                    Console.Write("A[{0}][{1}] = ", i, j);
                    DoubleArray[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
        
        //вывести элементы массива на экран;
        public void Show()
        {
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < DoubleArray.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < DoubleArray.GetLength(1); j++)
                {
                    Console.Write("{0} ", DoubleArray[i,j]);                    
                }
            }
        }
        //отсортировать элементы каждой строки массива в порядке убывания.
        public void SortArray()
        {
            double temp;
            for (int i = 0; i < DoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < DoubleArray.GetLength(0) - 1; j++)
                {
                    for (int z = j + 1; z < DoubleArray.GetLength(1); z++)
                    {
                        if (DoubleArray[i, j] < DoubleArray[i, z])
                        {
                            temp = DoubleArray[i, j];
                            DoubleArray[i, j] = DoubleArray[i, z];
                            DoubleArray[i, z] = temp;
                        }
                    }
                }
            }
        }

        //Свойства:
        //возвращает общее количество элементов в массиве (доступное только для чтения);
        public string Size => $"Размерность массива составляеть {DoubleArray.Length}";

        //позволяющее увеличить значение всех элементов массива на скаляр(доступное только для записи).
        public double Scalyar
        {
            set
            {
                for (int i = 0; i < DoubleArray.GetLength(0); i++)
                {
                    for (int j = 0; j < DoubleArray.GetLength(1); j++)
                    {
                        DoubleArray[i, j] *= value;
                    }
                }
            }
        }


    }
}
