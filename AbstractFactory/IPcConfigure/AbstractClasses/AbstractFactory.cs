using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcConfigure.AbstractClasses
{
    abstract class AbstractFactory
    {
        public abstract AbstractBox CreateBox();
        public abstract AbstractProcessor CreateProcessor();
        public abstract AbstractMainBoard CreateMainBoard();
        public abstract AbstractHdd CreateHdd();
        public abstract AbstractMemory CreateMemory();
        public abstract AbstractPc CreatePc();
    }
}
