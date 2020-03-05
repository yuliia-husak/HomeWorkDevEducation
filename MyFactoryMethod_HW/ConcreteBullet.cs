using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryMethod_HW
{
    class ConcreteBullet:AbstractBullet
    {
        double concreteCalibr;
        public ConcreteBullet()
        {
            Console.WriteLine(this.GetHashCode());
        }

        public ConcreteBullet(double cal)
        {
            concreteCalibr = cal;
            Console.WriteLine("ConcreteCalibr bullet: "+concreteCalibr);
        }
    }
}
