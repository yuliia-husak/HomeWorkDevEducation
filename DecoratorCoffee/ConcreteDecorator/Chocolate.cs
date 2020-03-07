using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee.ConcreteDecorator
{
    public class Chocolate : CondimentDecorator
    {        
        public override double cost()
        {
            if (bevegare == null) return 3.60;
            return 3.60 + bevegare.cost();
        }

        public override string GetDescription()
        {
            if (bevegare == null) Console.WriteLine("Chocolate");
            return bevegare.GetDescription() + ", Chocolate";
        }
    }
}
