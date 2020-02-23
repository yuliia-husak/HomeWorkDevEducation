using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using System.Threading;

namespace CarRaling
{
    [TestFixture]

    class CarRalingTest
    {
        Game gameTest = new Game(); 
        
        
        [Test]
        public void TimeTest()
        {
            Game gameTest = new Game();
            gameTest.AddCar(new Car(0, 0, "1", "CarTest"));
            gameTest.AddCar(new Car(0, 0, "2", "CarTest2"));  

            Assert.AreEqual(2, Game.carsCount);
        }

        [Test]
        public void WinTest()
        {
            gameTest.AddCar(new Car(0, 0, "1", "CarTest"));
            gameTest.AddCar(new Car(0, 0, "2", "CarTest2"));
            gameTest.Run();   
            gameTest.GetTime();
            Car vinCar = gameTest.getWinner();

            Assert.IsTrue(vinCar.Time > 0);
        }
    }
}
