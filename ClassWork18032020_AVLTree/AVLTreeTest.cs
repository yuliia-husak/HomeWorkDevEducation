using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;

namespace ClassWork18032020_AVLTree
{
    [TestFixture]
    class AVLTreeTest
    {
        [Test]
        public void SumAllElemTest_Return_369()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,26,30,34,7,17,24,29
            };
            int actual = 369;
            int sum = instance.Sum();
            Assert.AreEqual(sum, actual);
        }

        [Test]
        public void RemoveTest()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                21,10,28,6,15
            };
            instance.Remove(6);

            AVLTree<int> instance2 = new AVLTree<int>
            {
                21,10,28,15
            };

            CollectionAssert.AreEqual(instance, instance2);
        }

        [Test]
        public void AddTest()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                21,10,28,6,15
            };
            instance.Add(12);

            AVLTree<int> instance2 = new AVLTree<int>
            {
                21,10,28,15,6,12
            };

            CollectionAssert.AreEqual(instance, instance2);
        }

        [Test]
        public void FindTest()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                21,10,28,6,15
            };
            bool actual = instance.Contains(12);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void BalanceRightTest()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                9,6,4,7
            };            

            AVLTree<int> actual = new AVLTree<int> { 6 };

            Assert.AreEqual(instance.Head.Value, actual.Head.Value);
        }

        [Test]
        public void BalanceLeftTest()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                8,15,20,9,10
            };

            instance.Remove(9);
            AVLTree<int> actual = new AVLTree<int> { 15 };

            Assert.AreEqual(instance.Head.Value, actual.Head.Value);
        }

        [Test]
        public void BalanceRightLeftTest()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                10,20,15
            };

            AVLTree<int> actual = new AVLTree<int> { 15 };

            Assert.AreEqual(instance.Head.Value, actual.Head.Value);
        }

        [Test]
        public void BalanceLeftRightTest()
        {
            AVLTree<int> instance = new AVLTree<int>
            {
                20,10,15
            };

            AVLTree<int> actual = new AVLTree<int> { 15 };

            Assert.AreEqual(instance.Head.Value, actual.Head.Value);
        }
    }
}
