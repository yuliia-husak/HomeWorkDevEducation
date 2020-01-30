using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Circle : GeometricFigure
    {
        double a;
        public Circle(double a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return 3.14 * (a * 2);
        }

        public override double Perimetr()
        {
            Console.WriteLine("Perimeter is not calculated for this figure");
            return 0;
        }

        public override void Draw(int q)
        {
            //Console.WindowHeight = 50;
            //Console.WindowWidth = 110;  
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
