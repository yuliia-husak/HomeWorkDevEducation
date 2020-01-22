using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace MultyMoney
{
    [TestFixture]
    class MultyMoneyTest
    {
        [Test]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);           
            
            Assert.AreEqual(10, five.times(2));
            //Assert.AreEqual(new Dollar(10), five.times(2));
            //Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [Test]
        public void testFrancMultiplication()
        {
            Franc five = new Franc(5);

            Assert.AreEqual(10, five.times(2));
            //Assert.AreEqual(new Dollar(10), five.times(2));
            //Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [Test]
        public void testEquality()
        {    
            Assert.IsTrue(new Dollar(5).equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).equals(new Dollar(6)));
        }
    }
}
