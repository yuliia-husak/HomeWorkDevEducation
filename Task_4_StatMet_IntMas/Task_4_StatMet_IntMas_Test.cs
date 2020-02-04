using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace Task_4_StatMet_IntMas
{
    delegate int MyDel(int x);
   
    [TestFixture]
    class Task_4_StatMet_IntMas_Test
    {
        [Test]
        public void MultiTest()
        {
            int i = 10;

            i *= 10;

            Assert.AreEqual(100, i);
        }
    }
}
