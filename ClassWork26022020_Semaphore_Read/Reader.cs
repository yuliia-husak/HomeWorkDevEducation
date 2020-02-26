using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork26022020_Semaphore_Read
{
    class Reader
    {
        static Semaphore sem = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;

        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = "Читатель " + i.ToString();
            myThread.Start();
        }

        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();
                Console.WriteLine("{0} входит в библиотеку",Thread.CurrentThread.Name);

                Thread.Sleep(1000);

                Console.WriteLine("{0} выходит из библиотеки", Thread.CurrentThread.Name);

                sem.Release();
               
                Thread.Sleep(1000);
                count--;
            }            
        }
    }
}
