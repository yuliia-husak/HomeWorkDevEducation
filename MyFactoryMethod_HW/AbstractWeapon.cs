using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryMethod_HW
{
    abstract class AbstractWeapon
    {
        AbstractBullet bullet;

        double caliber;
        public abstract AbstractBullet CreateBullet();
        

        public void AnOperation()
        {
            bullet = CreateBullet();
            bullet.SetCaliber(this.GetCaliber());           
        }

        double GetCaliber()
        {
            return caliber;
        }
        void SetCaliber(double newCaliber)
        {
            caliber = newCaliber;
        } 
        
        public string SomeOperation()
        {
            var product = CreateBullet();
            var result = "Weapon: create bullet" + bullet.Operation();
            return result;
        }
    }
}
