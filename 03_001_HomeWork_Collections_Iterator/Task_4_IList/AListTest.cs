using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace _03_001_HomeWork_Collections_Iterator
{
    [TestFixture]
    class AListTest
    {        
        [Test]
        public void TestCountLength()
        {
            var test = new AList(); 
            test.Add("one");
            test.Add("two");
            test.Add("three");
            int i = test.Count;
           Assert.AreEqual(3, i);
        }

        [Test]
        public void TestInsertNewCount()
        {
            var test = new AList();
            test.Add("one");
            test.Add("two");
            test.Add("three");

            test.Insert(2, "insertTest");
            Assert.AreEqual(4,test.Count);
        }

        [Test]
        public void TestDelete()
        {
            var test = new AList();
            test.Add("one");
            test.Add("two");
            test.Add("three");

            test.Clear();
            Assert.AreEqual(0, test.Count);
        }

    }
}
