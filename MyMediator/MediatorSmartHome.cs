using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediator
{
    public abstract class MediatorSmartHome
    {
        public abstract void Send(string msg, Composition composition);
    }
}