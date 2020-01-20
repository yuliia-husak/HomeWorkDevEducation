using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrengthCherer;

namespace PassworStrengthChekerTests
{
    [TestClass]
    public class PasswordStrengthChekerTests
    {
        [TestMethod]
        public void Length_8_returned5()
        {
            //arrange
            string password = "P2sc0*isp";
            int expected = 5;

            //act            
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Length_5_returned3()
        {
            //arrange
            string password = "P2sc0";
            int expected = 3;

            //act            
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Length_6_returned1()
        {
            //arrange
            string password = "258456";
            int expected = 1;

            //act            
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
