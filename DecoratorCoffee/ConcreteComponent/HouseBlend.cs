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
        public override double cost()
        {
            return 6.00;
        }
    }
}
