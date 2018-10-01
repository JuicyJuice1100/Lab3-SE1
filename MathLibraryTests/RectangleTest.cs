using System;
using MathLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibraryTests
{
    [TestClass]
    public class RectangleTest
    {
        const double doubleMax = Double.MaxValue;
        const double doubleMin = Double.MinValue;
        const double NaN = Double.NaN;

        [TestMethod]
        public void TestMaxVolume()
        {
            Rectangle Rectangle = new Rectangle
            {
                Height = doubleMax,
                Width = doubleMax
            };

            Assert.AreEqual(Double.NaN, Rectangle.Volume());
        }

        [TestMethod]
        public void TestMinVolume()
        {
            Rectangle Rectangle = new Rectangle
            {
                Height = doubleMin,
                Width = doubleMin
            };

            Assert.AreEqual(Double.NaN, Rectangle.Volume());
        }

        [TestMethod]
        public void TestNaNVolume()
        {
            Rectangle Rectangle = new Rectangle
            {
                Height = NaN,
                Width = NaN
            };

            Assert.AreEqual(Double.NaN, Rectangle.Volume());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullVolume()
        {
            Rectangle Rectangle = null;

            Assert.AreEqual(Double.NaN, Rectangle.Volume());
        }

        [TestMethod]
        public void TestMaxArea()
        {
            Rectangle Rectangle = new Rectangle
            {
                Height = doubleMax,
                Width = doubleMax
            };

            Assert.AreEqual(Double.PositiveInfinity, Rectangle.Area());
        }

        [TestMethod]
        public void TestMinArea()
        {
            Rectangle Rectangle = new Rectangle
            {
                Height = doubleMin,
                Width = doubleMin
            };

            Assert.AreEqual(Double.NaN, Rectangle.Area());
        }

        [TestMethod]
        public void TestNaNArea()
        {
            Rectangle Rectangle = new Rectangle
            {
                Height = NaN,
                Width = NaN
            };

            Assert.AreEqual(Double.NaN, Rectangle.Area());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullArea()
        {
            Rectangle Rectangle = null;

            Assert.AreEqual(Double.NaN, Rectangle.Area());
        }
    }
}
