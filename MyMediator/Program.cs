using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteSmartHome();
            var alarm = new Alarm(mediator);
            var coffemaker = new CoffeMaker(mediator);
            var shower = new Shower(mediator);
            var climate = new ClimateControl(mediator);

            mediator.Alarm = alarm;
            mediator.CoffeMaker = coffemaker;
            mediator.Shower = shower;
            mediator.ClimateControl = climate;

            alarm.AlarmEvent();
            //coffemaker.CoffeeTurn("I will do ");
            //shower.WaterHeating("I will do ");
            //climate.TemperatDay("Day ");

            Console.ReadKey();
        }
    }
}
