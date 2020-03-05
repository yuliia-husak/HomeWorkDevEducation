using IPcConfigure.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcConfigure.ConcreteHomePcFactory
{
    class ConcreteHomePcFactory : AbstractFactory
    {
        public override AbstractBox CreateBox()
        {
            return new HomePcFactoryBox();
        }
        
        public override AbstractHdd CreateHdd()
        {
            return new HomePcFactoryHdd();
        }

        public override AbstractMainBoard CreateMainBoard()
        {
            return new HomePcFactoryMainBoard();
        }

        public override AbstractMemory CreateMemory()
        {
            return new HomePcFactoryMemory();
        }

        public override AbstractPc CreatePc()
        {
            return new HomePcFactoryPc();
        }

        public override AbstractProcessor CreateProcessor()
        {
            return new HomePcFactoryProcessor();
        }
    }
}
