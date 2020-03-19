using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace _01_BTree_TDD
{
    [TestFixture]
    class BTreeTest
    {     
        [Test]
        public void SumAllElemTest_Return_369()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,26,30,34,7,17,24,29
            };
            int actual = 369;
            int s = instance.Sum();
            Assert.AreEqual(s, actual);
        }

        [Test]
        public void TestBranchChild()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,26,30,34,7,17,24,29
            };
            int actual = 8;
            int s = instance.BranchComprarisonChild();
            Assert.AreEqual(s, actual);
        }

        [Test]
        public void TestAmountNumber()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,9,30,34,7,9,24,29
            };
            int actual = 3;
            int s = instance.AmountNumber(9);
            Assert.AreEqual(s, actual);
        }

        [Test]
        public void TestMaxNumber()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,9,30,34,7,9,24,29
            };
            
            int actual = 34;
            int s = instance.Max();
            Assert.AreEqual(s, actual);
        }

        [Test]
        public void TestMaxCount()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,9,30,34,7,9,24,29
            };

            int actual = 1;
            int s = instance.AmountNumber(instance.MaxValue);
            Assert.AreEqual(s, actual);
        }

        [Test]
        public void TestTwoIdentical()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,26,9,34,7,17,24,29
            };

            bool actual = true;
            bool s = instance.MaxIdentical();
            Assert.AreEqual(s, actual);
        }
        
        //Написать функцию, определяющую максимальное количество одинаковых элементов бинарного дерева.
        [Test]
        public void TestMaxCountIdentical()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,6,6,15,25,10,3,9,12,18,9,26,9,10,7,17,10,10
            };

            int actual = 5;
            int s = instance.MaxCountIdentical();
            Assert.AreEqual(s, actual);
        }

        //Написать функцию, которая определяет, является ли бинарное дерево симметричным.
        [Test]
        public void TestTreeSymmetrical()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,6,6,15,25,10,3,9,12,18,9,26,9,10,7,17,10,10
            };

            bool actual = false;
            bool s = instance.TreeSymetrical();
            Assert.AreEqual(s, actual);
        }

        //На 3 уровне бинарного дерева найти колличество элементов.
        [Test]
        public void TestLevelMaxElement()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,26,30,34,7,17,24,29
            };

            //уровень 3 всего 8 элементов
            int actual = 8;
            int s = instance.SumElementLevel();
            Assert.AreEqual(s, actual);
        }

        //На каждом уровне бинарного дерева найти максимальный и миннимальный элемент.
        [Test]
        public void TestMinMaxElement()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,26,30,34,7,17,24,29
            };
            
            int[] actual = { 21, 10, 6, 3, 7, 28, 32, 34, 29 };
            int[] s = instance.FindMinMax();
            CollectionAssert.AreEqual(s, actual);
        }

        //Найти минимальный и максимальный пути между листьями бинарного дерева.
        [Test]
        public void TestWayTree()
        {
            BinaryTree<int> instance = new BinaryTree<int>
            {
                21,10,28,6,15,25,32,3,9,12,18,23,26,30,34,7,17,24,29
            };

            int[] actual = { 21, 28, 32, 34, 29 };
            int[] s = instance.WayTree();
            CollectionAssert.AreEqual(s, actual);
        }
    }
}
