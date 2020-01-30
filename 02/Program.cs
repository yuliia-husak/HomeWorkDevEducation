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
            int size = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Выберите фигуру: " +
                "\n1 = Треугольник,2 = Квадрат, 3 = Ромб,\n " +
                "4 = Прямоугольник, 5 = Параллелограмм,6 = Трапеция,\n" +
                "7 = Круг, 8 = Эллипс");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите цвет фигуры: " +
                "\n1 = синий,2 = красный,3 = зеленый,\n ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите расположение фигуры на экране: " +
                "\n1 = слева,2 = по центру, 3 = справа,\n ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите размер фигуры: " +
                "\n1 = 1, 2 = увеличить вдвое\n ");
            int r = int.Parse(Console.ReadLine());

            ColectionFigures[] colection = new ColectionFigures[size];

            switch (x)
            {
               
                case 1:
                    size++;
                    Triangle triangle = new Triangle(4, 3, 5); ;
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 80;
                    if (r == 1) triangle = new Triangle(4, 3, 5); 
                    if (r == 2) triangle = new Triangle(8, 6, 10); 
                    
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
                    if (r == 1) square = new Square(5);
                    if (r == 2) square = new Square(10);
                    square.Draw(p);
                    square.Info();
                    Console.ResetColor();
                    break;
                case 3:
                    Rhombus thombus = new Rhombus(10);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 90;
                    if (r == 1) thombus = new Rhombus(10);
                    if (r == 2) thombus = new Rhombus(20);
                    thombus.Draw(p);
                    thombus.Info();
                    Console.ResetColor();
                    break;
                case 4:
                    Rectangle rectangle = new Rectangle(4, 6);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 80;
                    if (r == 1) rectangle = new Rectangle(4, 6);
                    if (r == 2) rectangle = new Rectangle(8, 12);
                    rectangle.Draw(p);
                    rectangle.Info();
                    Console.ResetColor();
                    break;
                case 5:
                    Parallelogram parallelogram = new Parallelogram(4, 6);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 80;
                    if (r == 1) parallelogram = new Parallelogram(4, 6);
                    if (r == 2) parallelogram = new Parallelogram(8, 12);
                    parallelogram.Draw(p);
                    parallelogram.Info();
                    Console.ResetColor();
                    break;
                case 6:
                    Trapezoid trapezoid = new Trapezoid(6, 14, 6, 8, 4);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 20;
                    if (z == 3) p = 60;
                    if (r == 1) trapezoid = new Trapezoid(6, 14, 6, 8, 4);
                    if (r == 2) trapezoid = new Trapezoid(12, 28, 12, 16, 8);
                    trapezoid.Draw(p);
                    trapezoid.Info();
                    Console.ResetColor();
                    break;
                case 7:
                    Circle circle = new Circle(4);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 80;
                    if (r == 1) circle = new Circle(4);
                    if (r == 2) circle = new Circle(8);
                    circle.Draw(p);
                    circle.Info();
                    Console.ResetColor();
                    break;
                case 8:
                    Ellipse ellipse = new Ellipse(8, 6);
                    if (y == 1) Console.ForegroundColor = ConsoleColor.Blue;
                    if (y == 2) Console.ForegroundColor = ConsoleColor.Red;
                    if (y == 3) Console.ForegroundColor = ConsoleColor.Green;
                    if (z == 1) p = 0;
                    if (z == 2) p = 40;
                    if (z == 3) p = 80;
                    ellipse.Draw(p);
                    ellipse.Info();
                    Console.ResetColor();
                    break;

            }

            
            Console.WriteLine("Вывести все фигуры на экран? 1 - да, 2 - нет");

            try
            {
                
                int q = int.Parse(Console.ReadLine());
                switch (q)
                {
                    case 1:
                        Console.Clear();

                        Circle circle = new Circle(4);
                        circle.Draw(0);
                        circle.Info();

                        Ellipse ellipse = new Ellipse(8, 6);
                        ellipse.Draw(0);
                        ellipse.Info();

                        Square square = new Square(4);
                        square.Draw(0);
                        square.Info();
                        
                        Rectangle rectangle = new Rectangle(4, 6);
                        rectangle.Draw(0);
                        rectangle.Info();

                        Trapezoid trapezoid = new Trapezoid(2, 4, 6, 8, 4);
                        trapezoid.Draw(0);
                        trapezoid.Info();

                        Parallelogram parallelogram = new Parallelogram(4, 6);
                        parallelogram.Draw(0);
                        parallelogram.Info();                        

                        Rhombus thombus = new Rhombus(10);
                        thombus.Draw(0);
                        thombus.Info();                       

                        Rhombus rhombus = new Rhombus(6);
                        rhombus.Draw(0);
                        rhombus.Info();
                        
                        break;

                    case 2:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Not right simbol");
                
            }
            




            //Console.CursorSize = 26;
            //Console.CursorLeft = 25;

            //Console.SetCursorPosition(50, 25);
            //Console.Beep();

            //Console.Beep();
            //

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
