using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryMethod_HW
{
    abstract class AbstractBullet
    {
        double caliber;
        public double GetCaliber()
        {
            return caliber;
        }
        public void SetCaliber(double newCaliber)
        {
            caliber = newCaliber;
        }
        public string Operation() 
        {
            return "result of ConcreteBullet";
        }
    }
}
