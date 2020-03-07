using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public abstract class Bevegare
    {
        public string description = "Unknown bevegare";

        public string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
