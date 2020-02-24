using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;

namespace ClassWork24022020_Stack_PolskayNode
{
    [TestFixture]
    class ScobkiTest
    {
        [Test]
        public void ScobkiError()
        {
            Scobki scobki = new Scobki("{ }");
            scobki.AnalisScobki();

            Assert.AreEqual(0, 1);
        }
    }
}
