using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;


namespace ClassWork24012020
{
    [TestFixture]
    class CountTest
    {
        [SetUp]
        
        FisCount fisCount = new FisCount(1000, 20, "20.01.2020");
        YurCount yurCount = new YurCount(100000, 30, "20.01.2020");

        [Test]
        public static void testNotEmpty()
        {  
            
            bool isMoney;
            fisCount.NotEmptyCount(isMoney);

            Assert.IsTrue(true, fisCount.NotEmptyCount(isMoney));
        }

        [Test]
        public static void testGiveAmount500Balance500()
        {
            fisCount.GiveAmount(500);
            int balanceTest = fisCount.Balance();

            Assert.AreEqual(500, balanceTest);
        }

        [Test]
        public static void testOpeningDate_20012020()
        {
            string DataTest = "20.01.2020";

            Assert.AreEqual(DataTest, fisCount.OpeningDate);
        }

        [Test]
        public static void testInterestAccrual()
        {
            int AccrualTest = fisCount.beginbalans;  

            Assert.AreEqual();
        }
    }
}
