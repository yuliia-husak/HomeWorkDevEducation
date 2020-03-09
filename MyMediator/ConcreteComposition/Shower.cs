using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediator
{
    class Shower : Composition
    {
        public Shower(MediatorSmartHome mediator) : base(mediator)
        {
        }

        internal void WaterHeating(string msg)
        {
            string water = " temperature water = 38 C ";
            Console.WriteLine(this.GetType().Name + water);
            mediator.Send(water, this);
        }
    }
}