using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstractFactory
{
    class FantaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new FantaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new FantaWater();
        }

        public override AbstractCover CreateCover()
        {
            return new FantaCover();
        }
        public override AbstractLabel CreateLabel()
        {
            return new FantaLabel();
        }

    }
}
