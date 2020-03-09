using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediator
{
    class Alarm : Composition
    {
        public Alarm(MediatorSmartHome mediator):base(mediator)
        {
        }

        public void AlarmEvent()
        {
            string sound = " sound ";
            Console.WriteLine(this.GetType().Name + sound + " in 7:00 ");
            mediator.Send(sound, this);
        }
    }
}