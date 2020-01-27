using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27012020_Interface_HumanShop
{
    class Director : Employee, IManager
    {
        public void Control()
        {
            Console.WriteLine("Director control method");
        }

        public void Motivation()
        {
            Console.WriteLine("Director motivation method");
        }
    }
}
