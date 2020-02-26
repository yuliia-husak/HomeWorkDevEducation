using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork26022020_Singronezed
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            for(int i = 0; i <threads.Length; ++i)
            {

                //*************1 способ*********************
                /* threads[i] = new Thread(delegate ()
                   {
                       for (int j = 1; i <= 1000000; ++j)
                           ++Counter.count;
                   });
                 threads[i].Start();*/

                //*************2 способ*********************
                threads[i] = new Thread(delegate ()
                  {
                      for (int j = 1; j <= 1000000; ++j)
                          Interlocked.Increment(ref Counter.count);
                  });
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; ++i)  
               threads[i].Join();//1: 1-3млн, 2 : 5 млн

            Console.WriteLine("counter = {0}", Counter.count);

            Console.ReadKey();
        }
    }
}
