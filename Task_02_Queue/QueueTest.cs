using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;

namespace Task_02_Queue
{
    [TestFixture]
    class QueueTest
    {
        Queue<int> vs = new Queue<int>();
       

        [Test]
        public void QuiueCountTest()
        {
            vs.Enqueue(2);
            vs.Enqueue(5);
            Assert.AreEqual(2, vs.Count);
        }

        [Test]
        public void DeleteCountTest()
        {
            vs.Enqueue(2);
            vs.Enqueue(5);
            vs.Dequeue();            
            Assert.AreEqual(1, vs.Count);
        }
    }
}
