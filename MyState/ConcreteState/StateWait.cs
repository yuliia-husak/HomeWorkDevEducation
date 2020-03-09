using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyState
{
    class StateWait : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Machine wait ");
            context.State = new StatePay();
        }
    }
}