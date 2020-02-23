using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace _03_001_HomeWork_Collections_Iterator
{
    [TestFixture]
    class AListTest
    {
        object[] vs = new object[] { "one","two","three" };               

        [Test]
        public void Test()
        {
           // Assert.AreEqual(24, reservoir1.Volume());
        }

        [Test]
        public void TestArea24Returned8()
        {
            //Assert.AreEqual(8, reservoir1.Area());
        }

        [Test]
        public void TestTypeReturned0()
        {
            //Assert.AreEqual(0, Reservoir.CompareType(reservoir1, reservoir2));
        }

    }
}
