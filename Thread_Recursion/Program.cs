using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Recursion
{
    class Program
    {
        static void ThreadRecursion(object counter)
        {    
           int n = (int)counter;
           if (n <= 0) return;
           Thread thread = new Thread(ThreadRecursion);
           thread.Priority = ThreadPriority.Lowest;
           Thread.Sleep(300);
           thread.Name = "Thread" + n;
           thread.Start(n - 1);
           Console.WriteLine("ThreadRecursion 1: " + Thread.CurrentThread.GetHashCode());  
           Console.WriteLine(new string('-', 20));
        }

        static void Main(string[] args)
        {
            ThreadRecursion(10);
            Thread.Sleep(800);
            Console.WriteLine("Main thread()");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread() for {0}", i);
            }
            
           
            
            Console.Read();
        }
    }
}
