using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    delegate int Operation(int number);

    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };
            Operation del = Mult10;

            foreach (var item in MyMethod(array, del))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static int[] MyMethod(int[] array, Operation del)
        {
            var count = array.Length;
            var result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = del(array[i]);
            }
            return result;
        }

        static int Mult10(int number)
        {
            return number * 10;
        }
    }
}
