using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace _02_002_Classes_Consstructors._04_Task_Fraction
{
    [TestFixture]
    class FractionTest
    {
        [SetUp]
        public void TestStart()
        {
            Fraction fraction = new Fraction(1, 2);
            Fraction fraction1 = new Fraction(2, 3);

            
        }

        [Test]
        public void SumTest()
        {
            Fraction fraction = new Fraction(1, 2);
            Fraction fraction1 = new Fraction(2, 3);
            Fraction fractionTestSum = new Fraction(3, 6);
            
            //t=int.Parse(Fraction.Sum(fraction, fraction1));
            
            Assert.AreEqual(fractionTestSum.Numerator,
                f)
        }
    }
}
