using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CarRaling
{
    class Game
    {
        LinkedList<Car> cars;

        public double maxDistance = 100;
        public static int carsCount = 0;
        readonly Road road;

        public Game()
        {
            cars = new LinkedList<Car>();
            road = new Road();
        }

        public Game(double dist, int carsAmount)
        {

            maxDistance = dist;
            for (int i = 0; i < carsAmount; i++)
            {
                cars.AddLast(new Car());
            }
        }

        public void AddCar(Car car)
        {
            cars.AddLast(car);
            carsCount++;
        }

        public void CalculateDistance(Object car)
        {
            double TempDistance = 0;
            Car tempCar = (Car)car;

            while (TempDistance <= maxDistance)
            {
                TempDistance += tempCar.Speed * 0.1;
                Thread.Sleep(100);

                //Console.WriteLine($"Driver {tempCar.Name} on {tempCar.Model} went distance {TempDistance} from {maxDistance}");
            }           

        }

        public void Run()
        {
            
            foreach (Car car in cars)
            {
                car.Show(car.Name);
                Thread.Sleep(100);
                Console.WriteLine(car.Model + " speed" + car.Speed);
            }

            foreach (Car car in cars)
            {
                ParameterizedThreadStart trd = new ParameterizedThreadStart(CalculateDistance);
                Thread threadCar = new Thread(trd);
                threadCar.Start(car);
            }
            road.Movie();
            Thread.Sleep(1000);

            SetTime();

            //// Игровая петля.
            //while (true)
            //{
            //    try
            //    {
            //        Thread.Sleep(5000);
            //        //car1.Acceleration();
            //        //car2.Acceleration();
            //        //car3.Acceleration();
            //        road.speed = 0;
            //        getWinner();

            //    }
            //    catch (Exception e)
            //    {
            //        road.speed = 0;
            //        Console.SetCursorPosition(38, 20);
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine(e.Message);
            //        Console.BackgroundColor = ConsoleColor.Black;
            //        Console.ForegroundColor = ConsoleColor.Gray;

            //        Console.SetCursorPosition(0, 25);

            //        foreach (DictionaryEntry de in e.Data)
            //            Console.WriteLine("{0}: {1}", de.Key, de.Value);

            //        break;
            //    } 
            //}            
        }

        public void SetTime()
        {
            foreach (var car in cars)
            {
                car.Time = maxDistance / car.Speed;
            }
        }

        public void GetTime()
        {
            foreach (var car in cars)
            {
                //Console.WriteLine($"Driver {car.Name} on car {car.Model} with speed {car.Speed} drive distance in time = {car.Time}");
            }
        }

        public Car getWinner()
        {
            double bestTime = cars.Min(c => c.Time);
            Car bestCar = cars.Where(c => c.Time == bestTime).First();
            road.speed = 0;
            return bestCar;
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
