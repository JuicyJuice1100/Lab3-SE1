using System;
using MathLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibraryTests
{
    [TestClass]
    public class BoxTest
    {
        const double doubleMax = Double.MaxValue;
        const double doubleMin = Double.MinValue;
        const double NaN = Double.NaN;

        [TestMethod]
        public void TestMaxVolume()
        {
            Box boxMax = new Box
            {
                Height = doubleMax,
                Width = doubleMax,
                Length = doubleMax
            };

            Assert.AreEqual(double.PositiveInfinity, boxMax.Volume());
        }

        [TestMethod]
        public void TestMinVolume()
        {
            Box boxMin = new Box
            {
                Height = doubleMin,
                Width = doubleMin,
                Length = doubleMin
            };

            Assert.AreEqual(double.NaN, boxMin.Volume());
        }

        [TestMethod]
        public void TestNaNVolume()
        {
            Box boxNaN = new Box
            {
                Height = NaN,
                Width = NaN,
                Length = NaN
            };

            Assert.AreEqual(double.NaN, boxNaN.Volume());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullVolume()
        {
            Box boxNull = null;

            Assert.AreEqual(double.NaN, boxNull.Volume());
        }

        [TestMethod]
        public void TestMaxArea()
        {
            Box boxMax = new Box
            {
                Height = doubleMax,
                Width = doubleMax,
                Length = doubleMax
            };

            Assert.AreEqual(double.PositiveInfinity, boxMax.Area());
        }

        [TestMethod]
        public void TestMinArea()
        {
            Box boxMin = new Box
            {
                Height = doubleMin,
                Width = doubleMin,
                Length = doubleMin
            };

            Assert.AreEqual(double.NaN, boxMin.Area());
        }

        [TestMethod]
        public void TestNaNArea()
        {
            Box boxNaN = new Box
            {
                Height = NaN,
                Width = NaN,
                Length = NaN
            };

            Assert.AreEqual(double.NaN, boxNaN.Area());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullArea()
        {
            Box boxNull = null;

            Assert.AreEqual(double.NaN, boxNull.Area());
        }
    }
}
