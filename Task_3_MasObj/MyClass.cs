using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_MasObj
{
    public delegate void MyDelegate(char c);
    class MyClass
    {
        public char c;
        public void Method(char c)
        {
            this.c = c;
        }
    }
}
