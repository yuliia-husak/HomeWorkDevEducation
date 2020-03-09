using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyState
{
    class StateGoodsStock : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Good is stock ");
            context.State = new StateSell();
        }
    }
}