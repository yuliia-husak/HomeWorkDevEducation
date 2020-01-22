using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [TestFixture]
    class MyClassTest
    {
        [Test]
        public void Tr()
        {
            Tr tr = new Tr(1,1,1);

            Assert.AreEqual(3, tr.PerCount);
        }

        [Test]
        public void Area()
        {
            Tr tr = new Tr(5, 4, 3);

            Assert.AreEqual(6.00, tr.AreaCount);
        }

        [Test]
        public void MayBe()
        {
            Tr tr = new Tr(0, 5, 1);           
            
            Assert.AreEqual(false, tr.IsTriangle);
        }
    }

   
}
