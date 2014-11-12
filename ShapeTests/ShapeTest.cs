using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAnimator.Model.Shapes;

namespace ShapeTests
{
    [TestClass]
    public class ShapeTest
    {
        private readonly Shape testRectangle = new Rectangle();
        private readonly Shape testSpottedRectangle = new SpottedRectangle();

        [TestMethod]
        public void VerifyAreaOfRectangle()
        {
            double expected = this.testRectangle.Height*this.testRectangle.Width;
            double actual = this.testRectangle.CalculateArea();
            Assert.AreEqual(expected, actual, .001, "Area not calculated correctly.");
        }

        [TestMethod]
        public void VerifyAreaOfSpottedRectangle()
        {
            double expected = this.testSpottedRectangle.Height*this.testSpottedRectangle.Width;
            double actual = this.testSpottedRectangle.CalculateArea();
            Assert.AreEqual(expected, actual, .001, "Area not calculated correctly.");
        }
    }
}