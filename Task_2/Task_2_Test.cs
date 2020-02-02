using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using static Task_2.Program;

namespace Task_2
{
    [TestFixture]
    class Task_2_Test
    {
        char c = 'b';
        string s = "dilsb  bies";

        [Test]
        public void Count_o_returned_2()
        {            
            CountSumbString countTest = CountSumbol;
            int testres = countTest(c, s);
            Assert.AreEqual(2, testres);
        }

        [Test]
        public void Index_b_returned_4()
        {            
            CountSumbString countTest = IndexFirst;
            int testres = countTest(c, s);
            Assert.AreEqual(4, testres);
        }

    }
}
