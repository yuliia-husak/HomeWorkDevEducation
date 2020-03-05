using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryMethod_HW
{
    class ConcreteWeapon : AbstractWeapon
    {
        public override AbstractBullet CreateBullet()
        {
            return new ConcreteBullet();
        }
    }
}
