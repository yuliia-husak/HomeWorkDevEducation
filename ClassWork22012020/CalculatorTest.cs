using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace ClassWork22012020
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public static void TestOperations()
        {
            Calculator c = new Calculator();

            Assert.AreEqual(8, c.Add(3, 5));
            Assert.AreEqual(4, c.Sub(6, 2));
            Assert.AreEqual(24, c.Mul(8, 3));
            Assert.AreEqual(2, c.Div(6, 3));

            Assert.AreNotEqual(9, c.Add(3, 5)); // 3 + 5 != 9
        }

        
    }
}
