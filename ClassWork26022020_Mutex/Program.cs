using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork26022020_Mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();
            Thread[] threads = new Thread[5];
            for(int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(c.UpdateFields);
                threads[i].Start();
                Console.WriteLine(DateTime.Now);
            }

            for (int i = 0; i < threads.Length; ++i) 
               threads[i].Join();
            Console.WriteLine("Count: {0} + {1}\n\n", c.Count, DateTime.Now);


            Console.ReadKey();
        }
    }
}
