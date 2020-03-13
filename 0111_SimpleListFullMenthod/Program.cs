using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0111_SimpleListFullMenthod
{
    class Program
    {
        public static void ShowList(SimpleListNode<int> vs)
        {
            foreach(int i in vs)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            SimpleListNode<int> instanse = new SimpleListNode<int> { };
            instanse.Add(5);
            instanse.Add(8);
            instanse.Add(10);

            ShowList(instanse);

            instanse.Remove(8);
            ShowList(instanse);

            int[] arr = new int[5];
            instanse.CopyTo(arr, 2);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("----------");

            Console.WriteLine(instanse.Count);

            if (instanse.Contains(3))
            {
                Console.WriteLine("Number 3 yes");
            }
            else Console.WriteLine("Number 3 not");

            instanse.Clear();
            Console.WriteLine(instanse.Count);
            ShowList(instanse);
            Console.ReadKey();
        }
    }
}
