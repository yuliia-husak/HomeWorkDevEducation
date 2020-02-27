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

            //****************************************************************************************

            Console.WriteLine("Основной поток: ставим в очередь рабочий элемент");
            Random r = new Random();
            for (int i = 0; i < 10; ++i)
                ThreadPool.QueueUserWorkItem(WorkingElementMethod, r.Next(10));
            Console.WriteLine("Основной поток: выполняем другиу задачи");
            Thread.Sleep(3000);
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                       
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

        private static void WorkingElementMethod(object state)
        {
            Console.WriteLine("\tпоток: {0} состояние = {1}", Thread.CurrentThread.ManagedThreadId, state);
            Thread.Sleep(1000);
        }
    }
}
