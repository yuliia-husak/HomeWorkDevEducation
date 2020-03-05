using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstractFactory
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }
        public override AbstractLabel CreateLabel()
        {
            return new CocaColaLabel();
        }
    }
}
