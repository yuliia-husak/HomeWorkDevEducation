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
        public Trapezoid(double a, double b, double c, double d, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;            
            this.d = d;
            this.h = h;
        }
        public override double Area()
        {            
            return ((a + b) / 2) * h;
        }
        public override double Perimetr()
        {
            return a + b + c + d;
        }
        public override void Draw(int q)
        {
            int propusk =(int)(b-a)/2;
            int left =(int) (b - propusk);
            
            for (int i = 1; i <= a; i++, Console.WriteLine(), propusk--)
            {                
                var x = Console.CursorLeft;
                var y = Console.CursorTop;
                Console.SetCursorPosition(x + q, y);
                for (int j = 1; j <= b; j++)
                {
                    if (j <= propusk)
                    {
                        Console.Write(" " + " ");
                        
                    }
                    if (j > left && (b-j) < propusk)
                    {
                        Console.Write(" " + " ");

                    }
                    if (j > propusk && j <= b-propusk)
                    {
                        Console.Write(" " + "*");
                    }                    

                }
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
