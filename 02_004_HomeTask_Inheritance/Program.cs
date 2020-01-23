using _02_004_HomeTask_Inheritance.PartialClassesAndMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_004_HomeTask_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //**************PartialClassesAndMethod*******
            XY xy = new XY(1, 2);
            //Console.WriteLine(xy.X + xy.Y); //before method
            xy.ShowXY();
            //--------------------------------------------


            Console.ReadKey();
        }
    }
}
