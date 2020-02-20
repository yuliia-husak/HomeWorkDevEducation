using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Car
    {
        public string Name { get; set; }
        public int speed=0;

        int gamespeed = 0;
        Random r = new Random();

        public int moveCar(int speed)
        {            
           int a = r.Next(0, 5);                
           gamespeed += a;
           return a;
        }
    }
}
