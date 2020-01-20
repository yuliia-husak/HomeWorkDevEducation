using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalc;


namespace MyCalc.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Differ_30and10_20returned()
        {
            //arrange
            int x = 30;
            int y = 10;
            int expected = 20;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Differ(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
