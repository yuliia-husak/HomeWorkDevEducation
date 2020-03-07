using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public class DarkRoast : Bevegare
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public new string GetDescription()
        {
            return description;
        }

        public override double cost()
        {
            return 7.00;
        }
    }
}
