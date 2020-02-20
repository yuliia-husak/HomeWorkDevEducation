using System;
using System.Threading;
using System.Collections;

namespace CarRaling
{
    class Game
    {
        private readonly Car car1;
        private readonly Car car2;
        private readonly Car car3;
        readonly Road road;

        public Game()
        {            
            car1 = new Car(10, 35, "1");
            car2 = new Car(40, 35, "2");
            car3 = new Car(70, 35, "3");
            road = new Road();
        }

        public void Run()
        {
            car1.Show(car1.Name);
            car2.Show(car2.Name);
            car3.Show(car3.Name);
            Thread.Sleep(100);
            road.Movie();
            

            // Игровая петля.
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);                    
                    car1.Acceleration();
                    car2.Acceleration();
                    car3.Acceleration();

                }
                catch (Exception e)
                {
                    road.Speed = 0;
                    Console.SetCursorPosition(38, 20);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Message);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.SetCursorPosition(0, 25);

                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("{0}: {1}", de.Key, de.Value);

                    break;
                } 
            }            
        }

        public static int RandomSpeed()
        {
            Random rnd = new Random();
            int x = rnd.Next(5, 10);
            return x;
        }
    }

    
}
