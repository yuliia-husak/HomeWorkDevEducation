using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace AVLTreeNode
{
    [TestFixture]
    class AVLTreeNodeTest
    {
        [Test]
        public void SumAllElemTest_Return_369()
        {
            AVLTree<int> instance = new AVLTree<int>
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
            int sum = instance.Sum();
            Assert.AreEqual(sum, actual);
        }
    }
}
