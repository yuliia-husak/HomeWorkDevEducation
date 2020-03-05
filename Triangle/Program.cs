///Описать класс, представляющий треугольник. Предусмотреть методы для создания объектов, 
///перемещения на плоскости, изменения размеров и вращения на заданный угол. Описать свойства 
///для получения состояния объекта. При невозможности построения треугольника выбрасывается исключение.
///Написать программу, демонстрирующую все разработанные элементы класса. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(2, 2);
            Point b = new Point(1, -2);
            Point c = new Point(-2, 1); ;
            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine(triangle.ToString());
            Console.WriteLine(triangle.ToString("D"));
            
            Console.ReadLine();
        }
    }
}
