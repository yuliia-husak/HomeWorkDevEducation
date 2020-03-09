using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public class Espresso : Bevegare
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public new string GetDescription()
        {
            return description;
        }
        public override double cost()
        {
            return 12.00;
        }
    }
}
