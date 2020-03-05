using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcConfigure.AbstractClasses
{
    abstract class AbstractPc
    {
        public abstract void Interact(
            AbstractBox box,
            AbstractProcessor processor,
            AbstractMainBoard mainBoard,
            AbstractHdd hdd,
            AbstractMemory memory);        
    }
}
