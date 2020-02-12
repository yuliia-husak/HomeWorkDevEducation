using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork12022020_Thread
{
    class Program
    {
        static void WriteFirst()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine($"Thead WriteFirst {i}");
            }
        }
        static void WriteSecond()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine($"Thead WriteSecond {i}");
            }
        }
       
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thead main {i}");
            }


            Thread thread = new Thread(WriteFirst);
            Thread thread1 = new Thread(WriteSecond);

            thread.Priority = ThreadPriority.Normal;
            thread1.Priority = ThreadPriority.Lowest;

            thread.Start();
            thread1.Start();

            
            Console.ReadLine();
        }
    }
}
