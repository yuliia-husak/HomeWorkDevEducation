using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_008_HomeTask_Event_Tamagotchi
{
    class Program
    {
        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("  ()()   ");
            Console.WriteLine("  (* *)  ");
            Console.WriteLine(" (_____)*");           
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void LifeTama()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 6);
            while (true)
            {
                switch (x)
            {
                case 1:
                    Console.WriteLine(new string(' ', 10) + "Покормить");
                    break;
                case 2:
                    Console.WriteLine(new string(' ', 10) + "Погулять");
                    break;
                case 3:
                    Console.WriteLine(new string(' ', 10) + "Уложить спать");
                    break;
                case 4:
                    Console.WriteLine(new string(' ', 10) + "Полечить");
                    break;
                case 5:
                    Console.WriteLine(new string(' ', 10) + "Поиграть");
                    break;
            }
            
                Console.WriteLine(new string(' ', 10) + "Secondary");
                Console.ReadLine();
            }
        }

        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            Thread thread1 = new Thread(PressKeyA_Handler);
            thread1.Start();
            thread.Start();

            
            Console.ReadKey();
        }

        static void refrenSolo()
        {
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Console.Beep(783, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 600);
            Thread.Sleep(600);
        }
        static void coupleSolo()
        {
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(392, 600);
            Thread.Sleep(300 * 2);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(440, 600);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(783, 600);
            Thread.Sleep(600);
            Console.Beep(880, 300);
            Console.Beep(880, 300);
            Console.Beep(783, 300);
            Console.Beep(622, 300);
            Console.Beep(659, 600);
            Thread.Sleep(600);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(392, 600);
            Thread.Sleep(600);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(440, 600);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(783, 600);
            Thread.Sleep(600);
            Console.Beep(880, 300);
            Console.Beep(783, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 600);
            Thread.Sleep(600);
        }

        private static void Grasshoper()
        {
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(415, 300);
            Thread.Sleep(600);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 300);
            Console.Beep(440, 300);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(494, 300);
            Console.Beep(494, 100);
            Console.Beep(494, 100);
            Console.Beep(494, 300);
            Console.Beep(494, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 100);
            Console.Beep(523, 100);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(494, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 800);
        }

        private static void Tannenbaum()
        {
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(329, 500);
            Console.Beep(247, 500);
            Console.Beep(247, 500);
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(497, 500);
            Thread.Sleep(500);
            Console.Beep(497, 500);
            Console.Beep(277, 500);
            Console.Beep(277, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(329, 500);
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(329, 500);
        }

    }
}

