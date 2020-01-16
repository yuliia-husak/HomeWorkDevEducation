using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class Point
    {
        private string name;
        private int x;
        private int y;

        public string Name { get { return name; } set { name = value; } }    
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public int ScalyarX
        {
            set
            {
                if (value == 0)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} ноль не может быть.");
                x = value * x;
            }
        }

        public int ScalyarY
        {
            set
            {
                if (value == 0)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} ноль не может быть.");
                y = value * y;
            }
        }

        public Point() { name = "A"; x = 0; y = 0;}

        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }                     
        public void ShowPoint()
        {
            Console.WriteLine("Point {0}: x = {1}, y = {2} ", name, x, y);
        }

        public void Vector(int a, int b)
        {
            x += a;
            y += b;
        }

        public void CalculateDistance(Point point)
        {
            double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Distance from point 0,0 to point {0} = {1:0.00} ", name, r);
        }
    }
}
