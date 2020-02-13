using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Recursion_2
{
    class Program
    {
        static int deep;
        static void Main(string[] args)
        {
            Console.WriteLine("Main method ()");
            Thread thread = new Thread(Recursion) { Name = "Thread " + deep };
            thread.Start();
        }

        private static void Recursion()
        {
            Console.WriteLine("Thread " + Thread.CurrentThread.Name);           
            Thread.Sleep(1000);
            Thread thread = new Thread(Recursion);
            deep++;
            thread.Name = "Thread " + deep;
            thread.Start();
        }
    }
}
