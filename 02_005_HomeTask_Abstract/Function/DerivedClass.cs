using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_005_HomeTask_Abstract.Function
{
    class DerivedLine : BaseFunction
    {
        public readonly double A;
        public readonly double B;

        public DerivedLine()
            : base()
        {
            A = 0;
            B = 0;
        }        
        public DerivedLine(double a, double b)
        {
            A = a;
            B = b;
        }
       
        public override double CaalculPoint(double x)
        {
            return A * x + B;
        }

        public override void Show()
        {
            Console.WriteLine("Line, a = {0}, b = {1}, x = {2}", A, B,CaalculPoint(3));
        }
    }
}
