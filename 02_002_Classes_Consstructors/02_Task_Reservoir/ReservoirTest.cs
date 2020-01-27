using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace _02_002_Classes_Consstructors._02_Task_Reservoir
{
    [TestFixture]
    class ReservoirTest
    {
        Reservoir reservoir1 = new Reservoir("море", 2, 4, 3);
        Reservoir reservoir2 = new Reservoir("озеро", 5, 6, 7);
        List<Reservoir> reservoirs1 = new List<Reservoir>(3);        

        [Test]
       public void TestVolume243Returned24()
        {
            Assert.AreEqual(24, reservoir1.Volume());
        }

        [Test]
        public void TestArea24Returned8()
        {
            Assert.AreEqual(8, reservoir1.Area());
        }

        [Test]
        public void TestTypeReturned0()
        {            
            Assert.AreEqual(0, Reservoir.CompareType(reservoir1, reservoir2));
        }

    }
}
