using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Thombus : GeometricFigure
    {
        double a, b, c;
        public Thombus(double b, double c, double a)
        {
            this.b = 7;
            this.c = 7;
            this.a = 7;
        }
        public override double Area()
        {
            //throw new NotImplementedException();
            return b * c / 2;
        }
        public override double Perimetr()
        {
            return 4 * a;
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
