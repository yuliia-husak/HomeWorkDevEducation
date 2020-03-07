using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee.ConcreteDecorator
{
    public class Whip : CondimentDecorator
    {
        public override double cost()
        {
            return 4.85 + bevegare.cost();
        }

        public override string GetDescription()
        {
            return bevegare.GetDescription() + ", Whip";
        }
    }
}
