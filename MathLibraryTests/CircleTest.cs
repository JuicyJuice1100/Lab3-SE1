using System;
using MathLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibraryTests
{
    [TestClass]
    public class CircleTest
    {
        const double doubleMax = Double.MaxValue;
        const double doubleMin = Double.MinValue;
        const double NaN = Double.NaN;

        [TestMethod]
        public void TestMaxVolume()
        {
            Circle circle = new Circle
            {
                Radius = doubleMax
            };

            Assert.AreEqual(Double.NaN, circle.Volume());
        }

        [TestMethod]
        public void TestMinVolume()
        {
            Circle circle = new Circle
            {
                Radius = doubleMin
            };

            Assert.AreEqual(Double.NaN, circle.Volume());
        }

        [TestMethod]
        public void TestNaNVolume()
        {
            Circle circle = new Circle
            {
                Radius = NaN
            };

            Assert.AreEqual(Double.NaN, circle.Volume());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullVolume()
        {
            Circle circle = null;

            Assert.AreEqual(Double.NaN, circle.Volume());
        }

        [TestMethod]
        public void TestMaxArea()
        {
            Circle circle = new Circle
            {
                Radius = doubleMax
            };

            Assert.AreEqual(Double.PositiveInfinity, circle.Area());
        }

        [TestMethod]
        public void TestMinArea()
        {
            Circle circle = new Circle
            {
                Radius = doubleMin
            };

            Assert.AreEqual(Double.NaN, circle.Area());
        }

        [TestMethod]
        public void TestNaNArea()
        {
            Circle circle = new Circle
            {
                Radius = NaN
            };

            Assert.AreEqual(Double.NaN, circle.Area());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullArea()
        {
            Circle circle = null;

            Assert.AreEqual(Double.NaN, circle.Area());
        }
    }
}
