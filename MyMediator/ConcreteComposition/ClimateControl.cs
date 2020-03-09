using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediator
{
    class ClimateControl : Composition
    {
        public ClimateControl(MediatorSmartHome mediator) : base(mediator)
        {
        }

        internal void TemperatDay(string msg)
        {
            string climate = " temp in home = 24.5 C ";
            Console.WriteLine(this.GetType().Name + climate);           
        }
    }
}