using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public class Mocha : CondimentDecorator
    {    
        public override string GetDescription()
        {
            return bevegare.GetDescription() + ", Mocha";
        }

        public override double cost()
        {
            return 2.50 + bevegare.cost();
        }        
    }
}
