using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using System.Collections;

namespace ClassWork22012020
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
        public void AreSame()
        {
            string a = "hello";
            string b = "world";

            Assert.AreNotSame(a, b);
        }
    }

    [TestFixture]
    class ContainsTest
    {
        [Test]
        public void Contains()
        {
            ArrayList array = new ArrayList();
            array.Add("Alex");
            array.Add("Serg");
            array.Add("John");

            Assert.Contains("Alex", array);
        }
    }

    [TestFixture]
    class ComparisonsTest
    {
        private int a, b;

        [SetUp]
        public void Init()
        {
            a = 10;
            b = 20;
        }

        [Test]
        public void Greater()
        {
            Assert.Greater(b, a);

            Assert.GreaterOrEqual(b, a);
        }

        [Test]
        public void Less()
        {
            Assert.Less(a, b);

            Assert.LessOrEqual(a, b);
        }
    }

    [TestFixture]
    class TypeAssertTest
    {
        [Test]
        public void InInstanceOf()
        {
            Assert.IsInstanceOf(typeof(object), "hello");
            Assert.IsNotInstanceOf(typeof(string), 5);
        }
    }

    [TestFixture]
    class ConditionTest
    {
        Calculator calc;

        [SetUp]

        [Test]
        public void InInstanceOf()
        {
            Assert.IsInstanceOf(typeof(object), "hello");
            Assert.IsNotInstanceOf(typeof(string), 5);
        }
    }
}
