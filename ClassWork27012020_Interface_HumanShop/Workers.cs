using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27012020_Interface_HumanShop
{
    class Workers : Employee, IWorker
    {
        public bool Iswording => throw new NotImplementedException();

        public void Work()
        {

            Console.WriteLine("Worker work method");
        }
    }
}
