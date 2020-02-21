using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace CarRaling
{
    class Game
    {
        List<Car> list=new List<Car>(3);

        public int maxDistance = 100;


        private readonly Car car1;
        private readonly Car car2;
        private readonly Car car3;
        readonly Road road;

        public Game()
        {            
            car1 = new Car(10, 35, "1","Ferrary");
            car2 = new Car(40, 35, "2","BMV");
            car3 = new Car(70, 35, "3","Volga");
            road = new Road();
        }

        public void Run()
        {
            car1.Show(car1.Name);
            Console.WriteLine(car1.Model +": Speed"+ car1.Speed );
            car2.Show(car2.Name);
            Console.WriteLine(car2.Model + ": Speed" + car2.Speed);
            car3.Show(car3.Name);
            Console.WriteLine(car3.Model + ": Speed" + car3.Speed);
            road.DrawRoad();
            


            // Игровая петля.
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);                    
                    //car1.Acceleration();
                    //car2.Acceleration();
                    //car3.Acceleration();

                }
                catch (Exception e)
                {
                    //road.Speed = 0;
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
            Thread.Sleep(50);
            int x = rnd.Next(170, 200);
            return x;
        }
    }

    
}
