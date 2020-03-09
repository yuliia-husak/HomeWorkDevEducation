using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediator
{
    class ConcreteSmartHome : MediatorSmartHome
    {
        public ClimateControl ClimateControl { get; set; }

        public Shower Shower { get; set; }

        public CoffeMaker CoffeMaker { get; set; }

        public Alarm Alarm { get; set; }      

        public override void Send(string msg, Composition composition)
        {
            if (composition == Alarm)
            {
                CoffeMaker.CoffeeTurn(msg);   
            }
            else if (composition == CoffeMaker)
            {
                Shower.WaterHeating(msg);
                ClimateControl.TemperatDay(msg);
            }
        }
    }
}