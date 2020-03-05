using IPcConfigure.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPcConfigure
{
    interface IPcFactory
    {
        void CreatePc();
        void CreateBox();
        void CreateProcessor();
        void CreateMainBoard();
        void CreateHdd();
        void CreateMemory();
    }
}
