using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyState
{
    class StateSell : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Good sell ");
            context.State = new StateWait();
        }
    }
}