using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_005_HomeTask_Abstract.Figure
{
    // Класс для треугольников, производный от класса BaseFigure.
    class Triangle : BaseFigure
    {
        double pri_height;

        double pri_base;

        string Style;

        public double Height
        {
            get { return pri_height; }

            set { pri_height = value < 0 ? -value : value; }
        }

        public double Base
        {
            get { return pri_base; }

            set { pri_base = value < 0 ? -value : value; }
        }

        // Конструктор, используемый по умолчанию,
        public Triangle()
            : base()
        {
            Height = Base = 0.0;

            Style = "null";
        }

        // Конструктор для класса Triangle,
        public Triangle(string s, double w, double h, double b)
               : base(w, "triangle")
        {
            pri_height = h;

            pri_base = b;

            Style = s;
        }

        // Сконструировать равнобедренный треугольник,
        public Triangle(double x) : base(x, "triangle")
        {
            Style = "isosceles";
            Height = Base = x;

        }

        // Сконструировать копию объекта типа Triangle,
        public Triangle(Triangle ob) : base(ob)
        {
            Height = ob.Height;

            Base = ob.Base;

            Style = ob.Style;
        }

        // Переопределить метод Area() для класса Triangle,
        public override double Area()
        {
            return Width * Height / 2;
        }

        // Переопределить метод Perimetr() для класса Triangle,
        public override double Perimetr()
        {
            return Width + Height + Base;
        }

        // Показать тип треугольника,
        public void ShowStyle()
        {
            Console.WriteLine("Triangle " + Style);
        }

        public override void ShowDim()
        {
            Console.WriteLine("Width {0}, Height {1}, Base {2} ", Width, Height, Base);
        }
    }
}
