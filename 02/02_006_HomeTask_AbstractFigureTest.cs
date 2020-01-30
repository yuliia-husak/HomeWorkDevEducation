using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using _02_006_HomeTask_AbstractFigure.Figure;

namespace _02
{
    [TestFixture]
    class _02_006_HomeTask_AbstractFigureTest
    {
        [Test]
        public void AreaPerimetrSquare()
        {
            Square square = new Square(5);
            Assert.AreEqual(25, square.Area());
            Assert.AreEqual(20, square.Perimetr());
        }

        [Test]
        public void AreaPerimetrTriangle()
        {
            Triangle triangle = new Triangle(3, 7, 9);
            Assert.AreEqual(8.7856416954027896, triangle.Area());
            Assert.AreEqual(19, triangle.Perimetr());
        }

        [Test]
        public void AreaPerimetrRectangle()
        {
            Rectangle rectangle = new Rectangle(4, 8);
            Assert.AreEqual(32, rectangle.Area());
            Assert.AreEqual(24, rectangle.Perimetr());
        }

        [Test]
        public void AreaPerimetrCircle()
        {
            Circle circle = new Circle(8);
            Assert.AreEqual(50.24, circle.Area());
            Assert.AreEqual(0, circle.Perimetr());
        }

        [Test]
        public void AreaPerimetrEllipse()
        {
            Ellipse ellipse = new Ellipse(4, 6);
            Assert.AreEqual(75.359999999999999, ellipse.Area());
            Assert.AreEqual(329.44, ellipse.Perimetr());
        }

        [Test]
        public void AreaPerimetrParalllelogram()
        {
            Parallelogram parallelogram = new Parallelogram(8, 10);
            Assert.AreEqual(79.148659729870545, parallelogram.Area());
            Assert.AreEqual(36, parallelogram.Perimetr());
        }

        [Test]
        public void AreaPerimetrRhombus()
        {
            Rhombus rhombus = new Rhombus(8);
            Assert.AreEqual(48, rhombus.Area());
            Assert.AreEqual(32, rhombus.Perimetr());
        }

        [Test]
        public void AreaPerimetrTrapezoid()
        {
            Trapezoid trapezoid = new Trapezoid(4, 8, 10, 4, 8);
            Assert.AreEqual(48, trapezoid.Area());
            Assert.AreEqual(26, trapezoid.Perimetr());
        }



    }
}
