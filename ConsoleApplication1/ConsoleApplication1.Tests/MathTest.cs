using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication1.Tests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void GivenAdd_WhenOnePlusTwo_ThenThree()
        {
            var target = new Math();

            int expected = 3;
            int actual = target.Add(1, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAdd_WhenNegativeFivePlusTwo_ThenNegativeThree()
        {
            var target = new Math();

            int expected = -3;
            int actual = target.Add(-5, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenSubtract_WhenThreeMinusTwo_ThenOne()
        {
            var target = new Math();

            int expected = 1;
            int actual = target.Subtract(3, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenSubtract_WhenThreeMinusEight_ThenNegativeFive()
        {
            var target = new Math();

            int expected = -5;
            int actual = target.Subtract(3, 8);

            Assert.AreEqual(expected, actual);
        }
    }
}
