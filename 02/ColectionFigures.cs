using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_006_HomeTask_AbstractFigure;
using _02_006_HomeTask_AbstractFigure.Figure;


namespace _02
{
    class ColectionFigures: GeometricFigure
    {
        //55555555555555
        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void Draw(int a)
        {
            throw new NotImplementedException();
        }

        public override void Info()
        {
            throw new NotImplementedException();
        }

        public override double Perimetr()
        {
            throw new NotImplementedException();
        }

        //ColectionFigures[] figures = new ColectionFigures[8];

        public void ShowAll()
        {
            //BaseFigure[] figures = new BaseFigure[5];

            //figures[0] = new Triangle("isosceles", 8.0, 12.0, 5.0);

            //figures[1] = new Rectangle(10.0);

            //figures[2] = new Rectangle(10.0, 4.0);

            //figures[3] = new Triangle(7.0);

            //figures[4] = new Circle(4.0);

            //for (int i = 0; i < figures.Length; i++)
            //{

            //    Console.WriteLine("Object — " + figures[i].name);

            //    Console.WriteLine("Area = " + figures[i].Area());

            //    Console.WriteLine("Perimetr = " + figures[i].Perimetr());

            //    figures[i].ShowDim();

            //    Console.WriteLine();
            //}
        }

        public static implicit operator ColectionFigures(Rectangle v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ColectionFigures(Square v)
        {
            throw new NotImplementedException();
        }
    }
}
