using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Point
            //Point p = new Point();
            //Point p1 = new Point("a", 2, 5);

            //p.X = 2;
            //p1.Y = 3;

            //p.ShowPoint();
            //p1.ShowPoint();

            //p1.Name = "B";
            //Console.WriteLine(p1.Name);

           
            //p1.ScalyarX = 2;
            //p1.ScalyarY = 3;
            //p1.ShowPoint();

            //Console.Write("Enter vector coordinates: x = ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int d = int.Parse(Console.ReadLine());

            //p1.Vector(c, d);
            //p1.ShowPoint();

            //p1.CalculateDistance(p1);
            #endregion
            #region ArrayOne
            //ArrayOne array = new ArrayOne(5);
            //array.KeyboardTouch();
            //array.Show();
            //array.SortArray();
            //array.Show();
            //Console.WriteLine(array.SizeArray);
            //array.Scalyar = 3;
            //array.Show();
            #endregion
            #region
            ArrayTwo two = new ArrayTwo(2, 2);
            two.KeyboardArray();
            two.Show();
            Console.WriteLine(two.Size);
            two.Scalyar = 2;
            two.Show();
            two.SortArray();
            two.Show();



            #endregion


            Console.ReadKey();
        }
    }
}
