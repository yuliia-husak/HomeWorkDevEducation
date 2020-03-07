using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public class Decaf : Bevegare
    {
        public Decaf()
        {
            description = "Decaf coffee";
        }

        public override double cost()
        {
            return 10.00;
        }
    }
}
