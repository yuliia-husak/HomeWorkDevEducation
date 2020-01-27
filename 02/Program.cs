using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_006_HomeTask_AbstractFigure.Figure;

namespace _02_006_HomeTask_AbstractFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorSize = 26;
            Console.CursorLeft=25;

            Console.SetCursorPosition(50, 25);
            Console.Beep();

            Square square = new Square(4);
            square.Draw();
            square.Info();

            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.Draw();
            rectangle.Info();

            Triangle triangle = new Triangle(4, 3, 5);
            triangle.Draw();            
            triangle.Info();

            Trapezoid trapezoid = new Trapezoid(2, 4, 6, 8,4);
            trapezoid.Draw();
            trapezoid.Info();

            Parallelogram parallelogram = new Parallelogram(4, 6);
            parallelogram.Draw();
            parallelogram.Info();

            Ellipse ellipse = new Ellipse(8, 6);
            ellipse.Draw();
            ellipse.Info();

            Thombus thombus = new Thombus(2, 4, 6);
            thombus.Draw();
            thombus.Info();

            Circle circle = new Circle(4);
            circle.Draw();
            circle.Info();

            var c = new _02.Figure.ConsoleCanvas(20);
            c.line(1, 1, 1, 7);
            c.line(12, 12, 1, 7);
            c.line(1, 12, 1, 1);
            c.line(1, 12, 7, 7);
            c.line(1, 12, 1, 7);
            Console.Write(c);
            


            Console.SetCursorPosition(10, 5);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@");

            Console.ReadKey();
        }
    }
}
