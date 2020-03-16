using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace ClassWork16032020_Tree
{
    [TestFixture]
    class TreeTest
    {
        [Test]
        public void TestAdd()
        {
            Tree<string> str = new Tree<string> { "string", "Hello" };

            Assert.AreEqual(2, str.Count);
        }

        [Test]
        public void TestContains()
        {
            Tree<string> str = new Tree<string> { "string", "Hello" };

            Assert.AreEqual(true, str.Contains("string"));
        }
    }
}
