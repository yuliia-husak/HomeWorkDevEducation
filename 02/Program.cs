using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _02;
using _02_006_HomeTask_AbstractFigure.Figure;

namespace _02_006_HomeTask_AbstractFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int p=0;

            Console.WriteLine("Выберите фигуру: " +
                "\n1=Треугольник,2=Квадрат, 3=Ромб,\n " +
                "4=Прямоугольник, 5=Параллелограмм,6= Трапеция,\n" +
                "7= Круг, 8=Эллипс");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите цвет фигуры: " +
                "\n1=синий,2=красный,3=зеленый,\n ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите расположение фигуры на экране: " +
                "\n1=слева,2=по центру, 3 =справа,\n ");
            int z = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Triangle triangle = new Triangle(4, 3, 5);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 80;
                    triangle.Draw(p);
                    triangle.Info();
                    Console.ResetColor();
                    break;
                case 2:
                    Square square = new Square(5);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 80;
                    square.Draw(p);
                    square.Info();
                    Console.ResetColor();
                    break;

            }
            



            //Console.CursorSize = 26;
            //Console.CursorLeft = 25;

            //Console.SetCursorPosition(50, 25);
            //Console.Beep();

            //Console.Beep();
            //Square square = new Square(4);
            //square.Draw();
            //square.Info();
            //Console.Beep();
            //Rectangle rectangle = new Rectangle(4, 6);
            //rectangle.Draw();
            //rectangle.Info();
            
            //Trapezoid trapezoid = new Trapezoid(2, 4, 6, 8, 4);
            //trapezoid.Draw();
            //trapezoid.Info();

            //Parallelogram parallelogram = new Parallelogram(4, 6);
            //parallelogram.Draw();
            //parallelogram.Info();

            //Ellipse ellipse = new Ellipse(8, 6);
            //ellipse.Draw();
            //ellipse.Info();

            //Thombus thombus = new Thombus(2, 4, 6);
            //thombus.Draw();
            //thombus.Info();

            //Circle circle = new Circle(4);
            //circle.Draw();
            //circle.Info();

            //var x = Console.CursorLeft;
            //var y = Console.CursorTop;
            //Console.WriteLine($"x = {x}, y = {y}");

            //x = Console.CursorLeft+25;
            //y = Console.CursorTop;
            //Console.WriteLine($"x = {x}, y = {y}");

            //Console.SetCursorPosition(x, y);
            //Console.WriteLine("@");

            //ColectionFigures[] figures = new ColectionFigures[2];
            //figures[0] = new Square(5);
            //figures[1] = new Rectangle(4, 6);


            Console.ReadKey();
        }

        private static void MissionImpossible()
        {
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(587, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(554, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(523, 1200);
            Thread.Sleep(150);
            Console.Beep(466, 150);
            Console.Beep(523, 150);
        }
    }
}
