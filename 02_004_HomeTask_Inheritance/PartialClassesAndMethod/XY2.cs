using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_004_HomeTask_Inheritance.PartialClassesAndMethod
{
    partial class XY
    {
        public int X { get; set; }

        partial void Show()
        {
            Console.WriteLine("{0}, {1}", X, Y);
        }
    }
}
