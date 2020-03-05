using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcConfigure.AbstractClasses
{
    class Client
    {
        readonly AbstractPc pc;
        private AbstractBox box;
        private AbstractProcessor processor;
        private AbstractMainBoard mainboard;
        private AbstractHdd hdd;
        private AbstractMemory memory;

        public Client(AbstractFactory factory)
        {
            pc = factory.CreatePc();
            box = factory.CreateBox();
            processor = factory.CreateProcessor();
            mainboard = factory.CreateMainBoard();
            hdd = factory.CreateHdd();
            memory = factory.CreateMemory();
        }

        public void Run()
        {
            pc.Interact(box,processor, mainboard,hdd,memory);   
            
        }
    }
}
