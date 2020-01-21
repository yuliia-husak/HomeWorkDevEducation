using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_003_TDD_DZ_1
{
    public class Sqr
    {
        double x;
        public double X
        {
            get { return x; }
        }

        public Sqr()
        {

        }

        public Sqr(double x)
        {
            this.x = x;
        }

        public static double SqureRoot(double input)
        {
            if (input <= 0)
            {
                throw new ArgumentOutOfRangeException("Is not negatig!!!");
            }

            double result = input, previousResult = -input;

            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = (result + input / result) / 2;
            }
            return result;

        }

    }
}
