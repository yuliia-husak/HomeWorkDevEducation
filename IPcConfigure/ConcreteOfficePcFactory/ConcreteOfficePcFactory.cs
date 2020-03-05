using IPcConfigure.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcConfigure.ConcreteOfficePcFactory
{
    class ConcreteOfficePcFactory : AbstractFactory
    {
        public override AbstractBox CreateBox()
        {
            return new OfficePcFactoryBox();
        }

        public override AbstractHdd CreateHdd()
        {
            return new OfficePcFactoryHdd();
        }

        public override AbstractMainBoard CreateMainBoard()
        {
            return new OfficePcFactoryMainBoard();
        }

        public override AbstractMemory CreateMemory()
        {
            return new OfficePcFactoryMemory();
        }

        public override AbstractPc CreatePc()
        {
            return new OfficePcFactoryPc();
        }

        public override AbstractProcessor CreateProcessor()
        {
            return new OfficePcFactoryProcessor();
        }
    }
}
