using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Triangle : GeometricFigure
    {
        double a, b, c;


        double h, p;
        //конструктор

        public bool IsTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a) { return true; }
                return false;
            }
        }
        public Triangle(double a, double b, double c)
        {   
                this.a = a;
                this.b = b;
                this.c = c;
        }       

        public override double Area()
        {

            if (IsTriangle)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                Console.WriteLine("Not be triangle!!!");
            return 0;
        }
        public override double Perimetr()
        {
            if (IsTriangle)
            {
                return (a + b + c);
            }

            else return 1;

        }

        public override void Draw()
        {
            if (IsTriangle)
            {
                p = (a + b + c) / 2;
                h = ((Math.Sqrt((p * ((p - a) * (p - b) * (p - c))) / a)));
                var l = (int)(h * 2 - 1);

                for (int i = 1; i <= h; i++,Console.WriteLine())
                {
                    for (int j = 1; j <= i; j++)
                       
                        Console.Write('*'+" ");
                }
            }
            else
                Console.WriteLine("Not be triangle!");

        }

        public override void Info()
        {
            Console.WriteLine($"Area {Area()}, Perimetr {Perimetr()}");
        }
    }
}
