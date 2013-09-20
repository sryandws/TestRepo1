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
    }
}
