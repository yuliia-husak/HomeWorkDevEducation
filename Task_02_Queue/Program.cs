using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Random rnd = new Random();
            for(int i = 0; i < 7; i++)
            {
                queue.Enqueue(rnd.Next(1, 20));
            }
            //Console.WriteLine("Enter seventh numbers:");
            //for (int i = 1; i < 8; i++)
            //{
            //    Console.Write($"Element {i}: ");
            //    int a = int.Parse(Console.ReadLine());
            //    queue.Enqueue(a);
            //}
            Console.WriteLine(new string('-', 50));
            Console.Write("Your queque: ");
            foreach (int item in queue)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            Console.Write("Enter number position: ");
            int x = int.Parse(Console.ReadLine());
            int c = queue.Count;
            for(int i = 0; i < c; i++)
            {
                if (i == x) queue.Dequeue();
                else
                {
                    int prom = queue.Dequeue();
                    queue.Enqueue(prom);
                }                
            }

            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(new string('-', 50));

            Console.WriteLine();
            queue.Dequeue();

            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }

            

            Console.ReadLine();
        }
    }
}
