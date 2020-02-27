using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace _03_001_HomeWork_Collections_Iterator.Task_5_NameMonth
{
    [TestFixture]
    class CollectionMonthTest
    {
        CollectionMonth<Element> cm = new CollectionMonth<Element>();

        [Test]
        public void TestCount()
        {
            cm[0] = new Element(1, "January", 31);
            //cm[1] = new Element(2, "February", 29);
            //cm[2] = new Element(3, "March", 31);
            int actual=0;
            foreach(Element element in cm)
            {
                actual++;
            }

            Assert.AreEqual(1, actual);
        }

    }
}
