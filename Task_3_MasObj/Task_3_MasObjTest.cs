using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace Task_3_MasObj
{
    [TestFixture]
    class Task_3_MasObjTest
    {
        MyClass[] clTest = new MyClass[2] { new MyClass(), new MyClass() };
        MyDelegate del = null;
        char ct = 'j';

        [Test]
        public void CheckChar()
        {
            foreach (MyClass item in clTest)
            {
                del += item.Method;
            }            
            del(ct);

            Assert.AreEqual(ct, clTest[0].c);
        }

        [Test]
        public void CheckCharArray()
        {
            int countArrayTest = 0;
            foreach (MyClass item in clTest)
            {
                del += item.Method;
            }
            del(ct);
            foreach (MyClass item in clTest)
            {
                if (item.c == ct) countArrayTest++;

            }

            Assert.AreEqual(clTest.Length, countArrayTest);
        }
    }
}
