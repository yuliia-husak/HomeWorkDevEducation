using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_03022020
{
    public class Car
    {
        public delegate double DistanceCalculatorDelegate(double fuelLevel,
            double fuelConsumption1km, double distance);

        private DistanceCalculatorDelegate dDelegate;
        public string Name { get; set; }
        public double FuelLevel { get; set; }
        public double FuelConsumption100km { get; set; }

        private double fuelConsumption1km;
        public Car(string name, double fuelLevel, double fuelConsumption100km)
        {
            Name = name;
            FuelConsumption100km = fuelConsumption100km;
            FuelLevel = fuelLevel;
            fuelConsumption1km = FuelConsumption100km / 100 * 1;
            this.dDelegate = dDelegate;
        }

        public void Drive(double distance)
        {
            //FuelLevel -= distance * fuelConsumption1km;
            //if (FuelLevel <= 0)
            //    Console.WriteLine("Машина заглохла {0}",distance);
            //else
            //    Console.WriteLine("Пройдена дистанция {0} км, осталось топлива {1} ",distance,FuelLevel, distance);
            FuelLevel = dDelegate(FuelLevel, FuelConsumption100km, distance);
        }

        public static class Servise
        {
            public static double DistanceCalculator(double fuelLevel, 
                double fuelConsumption1km, double distance)
            {
                fuelLevel -= distance * fuelConsumption1km;
                if(fuelLevel<=0)
                    Console.WriteLine("Машина заглохла {0}", distance);
                else
                    Console.WriteLine("Пройдена дистанция {0} км, осталось топлива {1} ", distance, fuelLevel);
                return fuelLevel;
            }

            public static double DistanceCalculatorWind(double fuelLevel,
                double fuelConsumption1km, double distance)
            {
                fuelLevel -= distance * fuelConsumption1km;
                fuelLevel -= 0.2;
                if (fuelLevel <= 0)
                    Console.WriteLine("Машина заглохла {0}", distance);
                else
                    Console.WriteLine("Пройдена дистанция {0} км, осталось топлива {1} ", distance, fuelLevel);
                return fuelLevel;
            }
        }
    }
}
