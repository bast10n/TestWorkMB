using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestWorkMB.tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CalculateArea_3and2and4_2_905returned()
        {
            int a = 3;
            int b = 2;
            int c = 4;
            double expected = 2.905;

            var area = new CalculateArea();
            var result = area.Shape(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateArea_3and3and5_4_146returned()
        {
            int a = 3;
            int b = 3;
            int c = 5;
            double expected = 4.146;

            var area = new CalculateArea();
            var result = area.Shape(a, b, c);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CalculateArea_3and3and3_3_897returned()
        {
            int a = 3;
            int b = 3;
            int c = 3;
            double expected = 3.897;

            var area = new CalculateArea();
            var result = area.Shape(a, b, c);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Any side of a triangle must be positive")]
        public void TriangleSidePositive()
        {
            int a = -3;
            int b = 3;
            int c = 3;

            var area = new CalculateArea();
            area.Shape(a, b, c);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The sum of lengths of any two sides should be greater than the length of third side")]
        public void TriangleSummLength()
        {
            int a = 7;
            int b = 2;
            int c = 3;

            var area = new CalculateArea();
            area.Shape(a, b, c);
        }
        [TestMethod]
        public void CalculateArea_3_28_274returned()
        {
            int radius = 3;
            double expected = 28.274;

            var area = new CalculateArea();
            var result = area.Shape(radius);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CalculateArea_25_1963_495returned()
        {
            int radius = 25;
            double expected = 1963.495;

            var area = new CalculateArea();
            var result = area.Shape(radius);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Positive number required")]
        public void CircleRadiusPositive()
        {
            int radius = -1;
            var area = new CalculateArea();
            area.Shape(radius);
        }
    }
}
