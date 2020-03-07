using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee.ConcreteDecorator
{
    public class Milk : CondimentDecorator
    {
        public override double cost()
        {
            return 1.55 + bevegare.cost();
        }

        public override string GetDescription()
        {
            return bevegare.GetDescription() + ", Milk";
        }
    }
}
