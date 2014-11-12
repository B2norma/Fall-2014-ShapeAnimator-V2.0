using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAnimator.Model.Shapes;

namespace ShapeTests
{
    [TestClass]
    public class ShapeTest
    {
        private Shape testRectangle = new Rectangle();
        private Shape testSpottedRectangle = new SpottedRectangle();

        [TestMethod]
        public void VerifyAreaOfRectangle()
        {
            double expected = testRectangle.Height*testRectangle.Width;
            double actual = testRectangle.CalculateArea();
            Assert.AreEqual(expected,actual,.001,"Area not calculated correctly.");
        }

        [TestMethod]
        public void VerifyAreaOfSpottedRectangle()
        {
            double expected = testSpottedRectangle.Height * testSpottedRectangle.Width;
            double actual = testSpottedRectangle.CalculateArea();
            Assert.AreEqual(expected, actual, .001, "Area not calculated correctly.");
        }
    }
}
