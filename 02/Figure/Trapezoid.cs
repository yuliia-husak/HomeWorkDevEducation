using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Trapezoid : GeometricFigure
    {
        double a, b, c, d, h;
        public Trapezoid(double b, double c, double a, double d, double h)
        {
            this.b = b;
            this.c = c;
            this.a = a;
            this.d = d;
            this.h = h;
        }
        public override double Area()
        {
            //throw new NotImplementedException();
            return ((a + b) / 2) * h;
        }
        public override double Perimetr()
        {
            return a + b + c + d;
        }
        public override void Draw()
        {
            for (int i = 1; i <= a; i++, Console.WriteLine())
            {
                for (int j = 1; j <= a; j++)

                    Console.Write(" " + i);
            }
        }

        public override void Info()
        {
            Console.WriteLine($"Area {Area()}, Perimetr {Perimetr()}");
        }
    }
}
