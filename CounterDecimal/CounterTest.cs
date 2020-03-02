using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace CounterDecimal
{
    [TestFixture]
    class CounterTest
    {       

        [Test]
        public static void CounterIncrement_1_return_2()
        {
            Counter counter = new Counter(2, 1, 10);
            counter.Rase();

            Assert.AreEqual(counter.GetCount, 3);
        }

        [Test]
        public static void CounterDecrement()
        {
            Counter counter = new Counter(3, 1, 10);
            counter.Decrease();

            Assert.AreEqual(counter.GetCount, 2);
        }

        [Test]
        public static void CounterExeption()
        {

            try
            {
                Counter counter = new Counter(10, 1, 8);

                //если не возникает ошибки, тест провальный
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
