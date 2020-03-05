using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryMethod_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractWeapon weapon = null;
            AbstractBullet bullet = null;

            weapon = new ConcreteWeapon();
            bullet = weapon.CreateBullet();

            weapon.AnOperation();

            Console.WriteLine("Set the caliber of the bullet: 25");
            bullet.SetCaliber(25);

            Console.WriteLine("Go to the screen calibr: {0} ", bullet.GetCaliber());
            Console.WriteLine(weapon.SomeOperation());
            Console.WriteLine(bullet.Operation());

            Console.ReadKey();
        }
    }
}
