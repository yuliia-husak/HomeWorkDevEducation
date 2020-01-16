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
            #region ArrayTwo
            //ArrayTwo two = new ArrayTwo(2, 2);
            //two.KeyboardArray();
            //two.Show();
            //Console.WriteLine(two.Size);
            //two.Scalyar = 2;
            //two.Show();
            //two.SortArray();
            //two.Show();
            #endregion
            #region StringBuilder
            //StringBuilder builder = new StringBuilder(5);
            //Console.WriteLine("Enter numbers chars: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter string: ");
            //StringBuilder stringBuilder1 = new StringBuilder(Console.ReadLine());
            //MyString stringCl = new MyString(x, stringBuilder1);
            //Console.WriteLine(stringBuilder1);
            //Console.WriteLine("Coutn spase= {0}", stringCl.CountSpaces());
            //Console.WriteLine("Change string: ");
            //Console.WriteLine(stringCl.StrLow());

            //Console.WriteLine("Change string: ");
            //Console.WriteLine("stringCl.RemovePuncts()");

            //Console.WriteLine("Properties: " + stringCl.Size);
            //Console.WriteLine("Enter string: ");
            //StringBuilder stringBuilder2 = new StringBuilder(Console.ReadLine());
            //MyString stringCl12 = new MyString(stringBuilder2.Length, stringBuilder2);
            //stringCl12.N = stringBuilder2.Length;
            //Console.WriteLine("Properties Value: " + stringCl12.N);
            #endregion
            #region
            MyData dateTime1 = new MyData();
            Console.WriteLine(dateTime1.GetSetDate);

            Console.WriteLine("Enter date please format(yyyy,mm,dd) : ");
            DateTime dateTime2 = DateTime.Parse(Console.ReadLine());
            MyData MyData2 = new MyData(dateTime2);
            Console.WriteLine(dateTime2);


            MyData MyData3 = new MyData();
            Console.WriteLine(MyData3.GetSetDate);
            Console.WriteLine($"Work with date: {MyData3.GetSetDate}");
            Console.WriteLine($"Constructor date: {MyData3.GetSetDate}");

            Console.WriteLine($"The next day: {MyData3.NextDay()}");
            Console.WriteLine($"The previos day: {MyData3.PreviousDay()}");

            Console.WriteLine($"Until the end of month: {MyData3.HowDaysEndMonth()} days.");

            Console.WriteLine("Enter date please: ");
            DateTime dateTime4 = DateTime.Parse(Console.ReadLine());
            MyData2.GetSetDate = dateTime4;

            if (MyData2.Year) Console.WriteLine($"Year {dateTime4.Year} leap-year.");
            else Console.WriteLine($"Year {dateTime4.Year} don't leap-year.");
            #endregion

            Console.ReadKey();
        }
    }
}
