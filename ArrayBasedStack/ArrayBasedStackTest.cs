using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;

namespace ArrayBasedStack
{
    [TestFixture]
    class ArrayBasedStackTest
    {
        [Test]
        public void PushTest()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(5);

            Assert.AreEqual(1, stack.Size);
        }

        [Test]
        public void PopTest()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(5);
            stack.Push(8);
            stack.Push(10);
            stack.Push(3);

            stack.Pop();

            int[] arr = new int[stack.Size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = stack.Pop();
            }


            int[] arrTest = { 10, 8, 5 };
            CollectionAssert.AreEqual(arrTest, arr);
        }

        [Test]
        public void PeekTest()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(5);
            stack.Push(8);
            stack.Push(10);
            stack.Push(3);

            int actual = stack.Peek();

            Assert.AreEqual(3, actual);
        }
    }
}
