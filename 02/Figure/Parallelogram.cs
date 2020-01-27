using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Parallelogram : GeometricFigure
    {
        double a, b;
        //construktor
        public Parallelogram(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area()
        {
            return a * b * Math.Sin(a);
        }

        public override double Perimetr()
        {
            return 2 * a + 2 * b;
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
