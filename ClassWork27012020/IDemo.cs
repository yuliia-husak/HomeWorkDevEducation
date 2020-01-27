using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27012020
{
    interface IDemo
    {
        void Show();
        double Slina();
        int X { get; }
        int this[int i] { get;set; }
    }
}
