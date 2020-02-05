using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace Task_5_Lambda_Number3
{
    [TestFixture]
    class Task_5_Lambda_Number3_Test
    {
        delegate int MyDelegate(int x);

        MyDelegate myDelegate = null;
        int x;

        [Test]
        public void CheckNumber()
        {
            x = 123;

            myDelegate = x =>
            {
                int[] numb3 = new int[3];
                int count = 2;
                do
                {
                    numb3[count] = x % 10;
                    count--;
                } while ((x /= 10) != 0);

                string s = "";

                for (int i = 1; i <= 1; i++)
                {
                    s += numb3[2];
                    s += numb3[0];
                    s += numb3[1];
                }

                int result = int.Parse(s);
                return result;
            };

            Assert.AreEqual(312, myDelegate(x));
        }

    }
}
