using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncInput_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.AsyncRead();
            d.UserInput();
        }
    }
}
