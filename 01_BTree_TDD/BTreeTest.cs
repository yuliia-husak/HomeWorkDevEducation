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
                21,
                10,
                28,
                6,
                15,
                25,
                32,
                3,
                9,
                12,
                18,
                23,
                26,
                30,
                34,
                7,
                17,
                24,
                29
            };
            int actual = 369;
            int s = instance.Sum();
            Assert.AreEqual(s, actual);
        }
    }
}
