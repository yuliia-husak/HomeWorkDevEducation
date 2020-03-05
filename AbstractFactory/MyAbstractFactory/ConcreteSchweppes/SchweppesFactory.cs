using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstractFactory
{
    class SchweppesFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new SchweppesBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new SchweppesWater();
        }

        public override AbstractCover CreateCover()
        {
            return new SchweppesCover();
        }
        public override AbstractLabel CreateLabel()
        {
            return new SchweppesLabel();
        }
    }
}
