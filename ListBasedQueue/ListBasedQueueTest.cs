using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;

namespace ListBasedQueue
{
    [TestFixture]
    class ListBasedQueueTest
    {
        [Test]
        public void EnqueueTest()
        {
            MyQeque<int> qeque = new MyQeque<int>();
            qeque.Enqueue(25);
            qeque.Enqueue(15);

            int actual = qeque.Count;

            Assert.AreEqual(2, actual);
        }

        [Test]
        public void DequeueTest()
        {
            MyQeque<int> qeque = new MyQeque<int>();
            qeque.Enqueue(25);
            qeque.Enqueue(15);

            int actual = qeque.Dequeue();
            int actualCount = qeque.Count;

            Assert.AreEqual(25, actual);
            Assert.AreEqual(1, actualCount);
        }

        [Test]
        public void PeekTest()
        {
            MyQeque<int> qeque = new MyQeque<int>();
            qeque.Enqueue(25);
            qeque.Enqueue(15);

            int actual = qeque.Peek();
            int actualCount = qeque.Count;

            Assert.AreEqual(25, actual);
            Assert.AreEqual(2, actualCount);
        }
    }
}
