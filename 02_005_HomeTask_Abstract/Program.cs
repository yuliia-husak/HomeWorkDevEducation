using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_005_HomeTask_Abstract.Figure;
using _02_005_HomeTask_Abstract.Function;

namespace _02_005_HomeTask_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Figure
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
            #endregion

            #region Function
            BaseFunction[] func = new BaseFunction[3];

            func[0] = new DerivedLine(8.0, 12.0);

            func[1] = new DerivedKub(8.00, 10.0, 5.0);

            func[2] = new Hyperbola(4.0);
            

            for (int i = 0; i < func.Length; i++)
            {                
                func[i].Show();

                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
