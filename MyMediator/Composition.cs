using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediator
{
    public abstract class Composition
    {
        protected MediatorSmartHome mediator;

        protected Composition(MediatorSmartHome mediator)
        {
            this.mediator = mediator;
        }

    }
}