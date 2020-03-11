using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11032020_Refactoring
{
    class ChildrensPrice:Price
    {
        public override double GetCharge(int daysRented)
        {
            double result = 1.5;
            if (daysRented > 3)
            {
                result += (daysRented - 3) * 1.5;
            }
            return result;
        }

        public override int GetPruceCode()
        {
            return Movie.CHILDRENS;
        }
    }
}
