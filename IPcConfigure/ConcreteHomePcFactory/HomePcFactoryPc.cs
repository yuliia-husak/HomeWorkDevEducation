using IPcConfigure.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcConfigure.ConcreteHomePcFactory
{
    class HomePcFactoryPc:AbstractPc
    {
        public override void Interact(
            AbstractBox box,
            AbstractProcessor processor,
            AbstractMainBoard mainBoard,
            AbstractHdd hdd,
            AbstractMemory memory)
        {
            Console.WriteLine(this +
               " interacts with \n{0}, \n{1}, \n{2}, \n{3}, \nand {4}",
               box, processor, mainBoard, hdd, memory);
        }
    }
}
