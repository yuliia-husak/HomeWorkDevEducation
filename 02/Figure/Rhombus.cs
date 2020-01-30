using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Rhombus : GeometricFigure
    {
        double a;
        public Rhombus(double a)
        {            
            this.a = a;
        }
        public override double Area()
        {
            int h = (int)(a * 8 / 10);
            return a * h;
        }
        public override double Perimetr()
        {
            return a * 4;
        }

        public override void Draw(int q)
        {
            int center =(int) a / 2;
            for(int i = 0; i < a; i++)
            {
                var x = Console.CursorLeft;
                var y = Console.CursorTop;
                Console.SetCursorPosition(x + q, y);
                for (int j = 0; j < a; j++)
                {
                    if (i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                        {
                            Console.Write("*");
                        }
                        else Console.Write(" ");
                    }
                    else
                    {
                        if (j >= center + i - a + 1 && j <= center - i + a - 1)
                            Console.Write("*");
                        else Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
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
