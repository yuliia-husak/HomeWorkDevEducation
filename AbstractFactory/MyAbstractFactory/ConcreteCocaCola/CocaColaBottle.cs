using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstractFactory
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover, AbstractLabel label)
        {
            Console.WriteLine(this + " interacts with {0}, {1} and {2}",water,cover,label);
        }
    }
}
