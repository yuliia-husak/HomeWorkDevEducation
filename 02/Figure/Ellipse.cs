using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Ellipse : GeometricFigure
    {
        double a, b;
        //construktor
        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return 3.14 * a * b;
        }

        public override double Perimetr()
        {
            return 4 * (((3.14 * a * b) + (Math.Pow((a - b), 2) / a + b)));
        }

        public override void Draw(int a)
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
