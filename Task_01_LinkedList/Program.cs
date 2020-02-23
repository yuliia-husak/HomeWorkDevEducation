using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new LinkedList<int>();

            ts.Add(1);
            ts.Add(5);
            ts.Add(10);
            ts.Add(-15);
            ts.Add(123);
            ts.Add(28);
            ts.Add(14);

            foreach(var item in ts)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            ts.Delete(10);
            Console.WriteLine("Delete 10 and enter for screen: ");

            foreach (var item in ts)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
