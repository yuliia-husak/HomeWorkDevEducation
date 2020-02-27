using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork27022020_ManualResetEvent
{
    class Program
    {      

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Событие с ручным сбросом");
            ManualResetEvent mre = new ManualResetEvent(true);            

            for(int i = 0; i < 10; ++i)
            {
                ThreadPool.QueueUserWorkItem(SomeMethod, mre);                
            }


            Console.ReadKey();
        }

        static void SomeMethod(object obj)
        {
            EventWaitHandle ev = obj as EventWaitHandle;

            if (ev.WaitOne(10))
            {
                Console.WriteLine("Поток {0} успел проскочить", Thread.CurrentThread.ManagedThreadId);
                ev.Reset();
            }
            else Console.WriteLine("Поток {0} опоздал",
                Thread.CurrentThread.ManagedThreadId);  
        }
    }
}
