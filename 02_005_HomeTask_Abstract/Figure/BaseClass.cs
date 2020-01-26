using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_005_HomeTask_Abstract.Figure
{
    // Создать абстрактный класс,    
    abstract class BaseFigure
    {
        double pri_width;

        // Конструктор, используемый по умолчанию,
        public BaseFigure()
        {
            Width = 0.0;

            name = "null";
        }

        // Конструктор с параметрами.
        public BaseFigure(double w, string n)
        {
            Width = w;

            name = n;
        }

        // Сконструировать копию объекта BaseFigure.
        public BaseFigure(BaseFigure ob)
        {
            Width = ob.Width;

            name = ob.name;
        }

        // Свойства ширины и высоты объекта,
        public double Width
        {
            get { return pri_width; }

            set { pri_width = value < 0 ? -value : value; }
        }

        public string name { get; set; }

        public abstract void ShowDim();

        // Теперь метод Area() является абстрактным,
        public abstract double Area();

        public abstract double Perimetr();
    }
}
