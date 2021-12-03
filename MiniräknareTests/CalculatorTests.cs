using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miniräknare;

namespace Miniräknare.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var calc = new Calculator();
            var actual = calc.Add(5, 5);
            var expected = 10;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var calc = new Calculator();
            var actual = calc.Subtract(5, 5);
            var expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var calc = new Calculator();
            var actual = calc.Multiply(5, 5);
            var expected = 25;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var calc = new Calculator();
            var actual = calc.Divide(5, 5);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PowerTest()
        {
            var calc = new Calculator();
            var actual = calc.Power(5, 2);
            var expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SquareRootTest()
        {
            var calc = new Calculator();
            var actual = calc.SquareRoot(5);
            var expected = 2.23606797749979;
            Assert.AreEqual(expected, actual);
        }
    }
}