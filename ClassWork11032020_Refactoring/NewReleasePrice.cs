using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11032020_Refactoring
{
    class NewReleasePrice:Price
    {
        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetPruceCode()
        {
            return Movie.NEW_RELEASE;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return daysRented > 1 ? 2 : 1;
        }
    }
}
