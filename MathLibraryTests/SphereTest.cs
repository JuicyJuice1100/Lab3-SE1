using System;
using MathLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibraryTests
{
    [TestClass]
    public class SphereTest
    {
        const double doubleMax = Double.MaxValue;
        const double doubleMin = Double.MinValue;
        const double NaN = Double.NaN;

        [TestMethod]
        public void TestMaxVolume()
        {
            Sphere Sphere = new Sphere
            {
                Radius = doubleMax
            };

            Assert.AreEqual(Double.PositiveInfinity, Sphere.Volume());
        }

        [TestMethod]
        public void TestMinVolume()
        {
            Sphere Sphere = new Sphere
            {
                Radius = doubleMin
            };

            Assert.AreEqual(Double.NaN, Sphere.Volume());
        }

        [TestMethod]
        public void TestNaNVolume()
        {
            Sphere Sphere = new Sphere
            {
                Radius = NaN
            };

            Assert.AreEqual(Double.NaN, Sphere.Volume());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullVolume()
        {
            Sphere Sphere = null;

            Assert.AreEqual(Double.NaN, Sphere.Volume());
        }

        [TestMethod]
        public void TestMaxArea()
        {
            Sphere Sphere = new Sphere
            {
                Radius = doubleMax
            };

            Assert.AreEqual(Double.PositiveInfinity, Sphere.Area());
        }

        [TestMethod]
        public void TestMinArea()
        {
            Sphere Sphere = new Sphere
            {
                Radius = doubleMin
            };

            Assert.AreEqual(Double.NaN, Sphere.Area());
        }

        [TestMethod]
        public void TestNaNArea()
        {
            Sphere Sphere = new Sphere
            {
                Radius = NaN
            };

            Assert.AreEqual(Double.NaN, Sphere.Area());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullArea()
        {
            Sphere Sphere = null;

            Assert.AreEqual(Double.NaN, Sphere.Area());
        }
    }
}
