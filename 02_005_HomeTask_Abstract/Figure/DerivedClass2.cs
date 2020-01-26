using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_005_HomeTask_Abstract.Figure
{
    // Класс для прямоугольников, производный от класса BaseFigure
    class Rectangle : BaseFigure
    {
        double pri_height;

        public double Height
        {
            get { return pri_height; }

            set { pri_height = value < 0 ? -value : value; }
        }

        // Конструктор, используемый по умолчанию,
        public Rectangle()
            : base()
        {
            Height = 0.0;

            name = "null";
        }

        //Конструктор для класса Rectangle
        public Rectangle(double w, double h, string n)
                        : base(w, n)
        {
            pri_height = h;
        }

        //Конструктор для класса Rectangle,
        public Rectangle(double w, double h)
            : base(w, "rectangle")
        {
            Height = h;
        }

        // Сконструировать объект равной ширины и высоты,
        public Rectangle(double x, string n)
        {
            Width = Height = x;

            name = n;
        }

        // Сконструировать квадрат,
        public Rectangle(double x)
            : base(x, "square")
        {
            Height = x;
        }


        // Сконструировать копию объекта типа Rectangle,
        public Rectangle(Rectangle ob) : base(ob)
        {
            Height = ob.Height;
        }

        // Возвратить логическое значение true, если
        // прямоугольник окажется квадратом,
        public bool IsSquare()
        {
            if (Width == Height) return true;

            return false;
        }

        // Переопределить метод Area() для класса Rectangle,
        public override double Area()
        {
            if (Height == 0) return Width * 2;
            return Width * Height;
        }

        // Переопределить метод Perimetr() для класса Rectangle,
        public override double Perimetr()
        {
            if (Height == 0) return Width * 4;
            return (Width + Height) * 2;

        }

        public override void ShowDim()
        {

            Console.WriteLine("Width {0}, Height {1} ", Width, Height);
        }
    }
}
