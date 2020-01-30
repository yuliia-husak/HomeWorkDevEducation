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
            return 3.14 * (a * b);
        }

        public override double Perimetr()
        {
            return 4 * (((3.14 * a * b) + (Math.Pow((a - b), 2) / a + b)));
        }

        public override void Draw(int q)
        {
            var x = Console.CursorLeft;
            var y = Console.CursorTop;
            Console.SetCursorPosition(x + q, y);
            int r = 10;
            for (y = 0; y < r; ++y)
            {
                x = (int)Math.Round(2 * Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));

                Console.SetCursorPosition(x + r, y + r);
                Console.Write('*');
                Console.SetCursorPosition(x + r, -y + r);
                Console.Write('*');
                Console.SetCursorPosition(-x + 2 * r, -y + r);
                Console.Write('*');
                Console.SetCursorPosition(-x + 2 * r, y + r);
                Console.Write('*');
            }
            Console.SetCursorPosition(0, r * 2 + 2);
        }

        public override void Info()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("| Area  |  Perimetr  | ");
            Console.WriteLine($"|  {Area()}    |    {Perimetr()}      |");
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
        }
    }
}
