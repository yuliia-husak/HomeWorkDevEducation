using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure.Figure
{
    class Square : GeometricFigure
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }
        public override double Area()
        {
            //throw new NotImplementedException();
            return a * a;
        }

        public override double Perimetr()
        {
            return a + a + a + a;
        }


        public override void Draw(int q)
        {
            
            for (int i = 1; i <= a; i++, Console.WriteLine())
            {
                var x = Console.CursorLeft;
                var y = Console.CursorTop;
                Console.SetCursorPosition(x + q, y);
                for (int j = 1; j <= a; j++)

                    Console.Write(" " + "*");
            }
        }

        public override void Info()
        {
            Console.WriteLine($"Area {Area()}, Perimetr {Perimetr()}");
        }
    }
}
