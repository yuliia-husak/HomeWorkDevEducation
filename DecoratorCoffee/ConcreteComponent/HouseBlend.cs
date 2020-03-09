using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public class HouseBlind : Bevegare
    {
        public HouseBlind()
        {
            description = "House Blend Coffee";
        }

        public new string GetDescription()
        {
            return description;
        }
        public override double cost()
        {
            return 6.00;
        }
    }
}
