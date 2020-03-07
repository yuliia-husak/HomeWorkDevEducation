using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public abstract class CondimentDecorator : Bevegare
    {
        protected Bevegare bevegare;

        public void SetComponent(Bevegare bevegare)
        {
            this.bevegare = bevegare;
        }

        public abstract new string GetDescription();
    }
}
