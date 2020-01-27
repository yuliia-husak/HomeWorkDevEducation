using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Rectangle : GeometricFigure
    {
        double a, b;
        //construktor
        public Rectangle(double a, double b)
        {
            this.a = a ;
            this.b = b ;
        }

        public override double Area()
        {
            return a * b;
        }
        public override double Perimetr()
        {
            return (a + b) * 2;
        }
        public override void Draw(int a)
        {
            
            for (int i = 1; i <= a; i++, Console.WriteLine())
            {
                var x = Console.CursorLeft;
                var y = Console.CursorTop;
                Console.SetCursorPosition(x + 50, y);
                for (int j = 1; j <= b; j++)
                {
                    
                    Console.Write(" " + "*");
                }
            }

        }

        public override void Info()
        {
           Console.WriteLine( $"Area {Area()}, Perimetr {Perimetr()}");
        }
    }
}
