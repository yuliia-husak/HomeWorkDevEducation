using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;

namespace Task_01_LinkedList
{
    [TestFixture]
    class LinkedListTest
    {
        LinkedList<int> vs = new LinkedList<int> { 1, 5, 7, 10, 12 };

        [Test]
        public void CountTest()
        {
            vs.Add(255);
            Assert.AreEqual(6, vs.Count);
        }

        [Test]
        public void DeleteTest()
        {
            vs.Delete(255);
            Assert.AreEqual(5, vs.Count);

            bool test = vs.Contains(255);
            Assert.AreEqual(false,test);
        }

        [Test]
        public void ClearTest()
        {
            vs.Clear();
            Assert.AreEqual(0, vs.Count);
        }
    }
}
