using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counter;
using Counter2;
using MyCounter = Counter2.CountDown;

namespace Counter
{
    class NSDemo
    {
        static void Main()
        {
            Counter.CountDown cd1 = new Counter.CountDown(10);
            Counter2.CountDown cd = new Counter2.CountDown();

            MyCounter cd4 = new MyCounter();
           
            int i;

            do { 
                i = cd1.Count(); 
                Console.Write(i + " "); 
            } while (i > 0); 
            Console.WriteLine();

            Counter.CountDown cd2 = new Counter.CountDown(20);
            do
            {
                i = cd2.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();

            cd2.Reset(4); 
            do { 
                i = cd2.Count();
                Console.Write(i + " "); 
            } while (i > 0); 
            Console.WriteLine();

            cd.Count();

            Console.ReadKey();
        }
    }
}
