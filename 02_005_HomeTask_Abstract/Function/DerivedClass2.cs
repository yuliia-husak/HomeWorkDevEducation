using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_005_HomeTask_Abstract.Function
{
    class DerivedKub : BaseFunction
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;

        public DerivedKub()
            : base()
        {
            A = 0;
            B = 0;
            C = 0;
        }
       
        public DerivedKub(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CaalculPoint(double x)
        {
            return A * x * x + B * x + C;
        }

        public override void Show()
        {
            Console.WriteLine("Kub, a = {0}, b = {1}, c = {2}, x = {3}", A, B, C, CaalculPoint(3));
        }
    }
}

