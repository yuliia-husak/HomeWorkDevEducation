using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using System.IO;

namespace _02_BTree_FreqDictionary
{
    [TestFixture]
    class FreqDictionaryTest
    {
        [Test]
        public void StartTest()
        {
            FreqDictionary dictionary = new FreqDictionary();
            Assert.IsFalse(dictionary!=null);
        }

        [Test]
        public void CountTest()
        {
            FreqDictionary dictionary = new FreqDictionary();
            dictionary.Start
            Assert.IsFalse(dictionary != null);
        }
    }
}
