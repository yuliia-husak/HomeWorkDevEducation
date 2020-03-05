using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace TriangleTask
{
    [TestFixture]
    class TriangleTest
    {       

        [Test]
        public static void TriagleExeption()
        {
            try
            {
                Point a = default;
                Point b = default;
                Point c = default;
                Triangle triangle = new Triangle(a, b, c);

                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [Test]
        public static void TriagleMove()
        {
            Point a = new Point(2, 2);
            Point b = new Point(1, -2);
            Point c = new Point(-2, 1); ;
            Triangle triangle = new Triangle(a, b, c);

            triangle.sd_down(5);

            //Assert.AreEqual()

        }
    }
}
