using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_005_HomeTask_Abstract.Figure
{
    // Класс для круга, производный от класса BaseFigure.
    class Circle : BaseFigure
    {
        // Конструктор для класса Circle,
        public Circle(double w)
                     : base(w, "circle") { }

        //// Сконструировать круг,
        //public Circle(double x) : base(x, "circle") { }

        // Сконструировать копию объекта типа Circle,
        public Circle(Circle ob) : base(ob) { }

        // Переопределить метод Area() для класса Circle
        public override double Area()
        {
            return 3.14 * (Width * 2);
        }

        public override double Perimetr()
        {
            Console.WriteLine("Perimeter is not calculated for this figure");
            return 0;
        }

        public override void ShowDim()
        {
            Console.WriteLine("Radius and diameter = " +

                   Width + " and " + Width * 2);
        }
    }
}
