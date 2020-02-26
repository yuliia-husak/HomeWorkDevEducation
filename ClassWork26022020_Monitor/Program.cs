using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork26022020_Monitor
{
    class Program
    {
        static void Main(string[] args)
        {

            BadAsync();
            GoodAsync();
            Console.ReadKey();
        }

        public class InterLockedCounter
        {
            int field1;
            int field2;
            public int Field1
            {
                get { return field1; }
            }
            public int Field2
            {
                get { return field2; }
            }
            public void UpdateFields()
            {
                for (int i = 0; i < 1000000; ++i)
                {
                    Interlocked.Increment(ref field1);
                    if (field1 % 2 == 0) Interlocked.Increment(ref field2);
                }
            }

        }

        private static void GoodAsync()
        {
            Console.WriteLine("Synhron Blocking ");
            MonitorLockedCounter c = new MonitorLockedCounter();
            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(c.UpdateField);
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine("Field1:{0}, Field2: {1}\n\n", c.Field1, c.Field2);
        }

        class MonitorLockedCounter
        {
            int field1;
            int field2;
            public int Field1
            {
                get { return field1; }
            }
            public int Field2
            {
                get { return field2; }
            }
            public void UpdateField()
            {
                for (int i = 0; i < 1000000; i++)
                {
                    //Monitor.Enter(this);
                    //try
                    //{
                    //    ++field1;
                    //    if (field1 % 2 == 0)
                    //        ++field2;
                    //}
                    //finally
                    //{
                    //    Monitor.Exit(this);
                    //}
                    lock (this)
                    {
                        ++field1;
                        if (field1 % 2 == 0)
                            ++field2;
                    }
                }
            }
        }



        private static void BadAsync()
        {
            Console.WriteLine("Singr Interlocded=menthod:");
            InterLockedCounter c = new InterLockedCounter();
            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(c.UpdateFields);
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; ++i) threads[i].Join();

            Console.WriteLine("Fiels1: {0}, Field2: {1}\n\n", c.Field1, c.Field2);

        }
    }   
}
