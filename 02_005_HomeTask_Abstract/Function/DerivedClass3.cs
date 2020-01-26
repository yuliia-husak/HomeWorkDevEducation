using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_005_HomeTask_Abstract.Function
{
    class Hyperbola : BaseFunction
    {
        public readonly double A;
        
        public Hyperbola()            
        {
            A = 0;            
        }

        public Hyperbola(double a)
        {
            A = a;            
        }

        public override double CaalculPoint(double x)
        {
            return A / x;
        }

        public override void Show()
        {
            Console.WriteLine("Hyperbola, a = {0}, x = {1}", A, CaalculPoint(3));
        }
    }
}

