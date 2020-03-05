using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPcConfigure.AbstractClasses;

namespace IPcConfigure
{
    class ConcreteFactory : AbstractFactory
    {
        public override AbstractBox CreateBox()
        {
            return AbstractBox();
        }

        private AbstractBox AbstractBox()
        {
            return AbstractBox();
        }

        public override AbstractHdd CreateHdd()
        {
            return AbstractHdd();
        }

        private AbstractHdd AbstractHdd()
        {
            return AbstractHdd();
        }

        public override AbstractMainBoard CreateMainBoard()
        {
            return AbstractMainBoard();
        }

        private AbstractMainBoard AbstractMainBoard()
        {
            return AbstractMainBoard();
        }

        public override AbstractMemory CreateMemory()
        {
            return AbstractMemory();
        }

        private AbstractMemory AbstractMemory()
        {
            return AbstractMemory();            
        }

        public override AbstractPc CreatePc()
        {
            return AbstractPc();
        }

        private AbstractPc AbstractPc()
        {
            return AbstractPc();
        }

        public override AbstractProcessor CreateProcessor()
        {
            return AbstractProcessor();
        }

        private AbstractProcessor AbstractProcessor()
        {
            return AbstractProcessor();
        }
    }
}
