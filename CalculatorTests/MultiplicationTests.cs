using CalculationLibrary1;

namespace CalculatorTests
{
    [TestClass]
    public class MultiplicationTests

    {
        [TestMethod]
        public void MultipyDiffInteger()
        {
            double result = Calculations.Multiplication(3, 4);
            Assert.AreEqual(12, result);

        }
        [TestMethod]
        public void MultipySameInteger()
        {
            double result = Calculations.Multiplication(4, 4);
            Assert.AreEqual(16, result);

        }
        [TestMethod]
        public void MultipyPositiveInnteger()
        {
            double result = Calculations.Multiplication(50, 4);
            Assert.AreEqual(200, result);

        }
        [TestMethod]
        public void MultipynegativeInt()
        {
            double result = Calculations.Multiplication(-3, -4);
            Assert.AreEqual(12, result);

        }
        [TestMethod]
        public void MultipydifferentSignInt()
        {
            double result = Calculations.Multiplication(-3, 4);
            Assert.AreEqual(12, result);

        }
        [TestMethod]
        public void MultipyDecimalNumbers()
        {
            double result = Calculations.Multiplication(0.3, 0.04);
            Assert.AreEqual(0.34, result);

        }
        [TestMethod]
        public void MultipyNegativeDecimalNumbers()
        {
            double result = Calculations.Multiplication(0.3, -0.04);
            Assert.AreEqual(0.34, result);

        }
        [TestMethod]
        public void MultipyAZero()
        {
            double result = Calculations.Multiplication(0.3, 0.0);
            Assert.AreEqual(0.3, result);
        }
        [TestMethod]
        public void MultipyFractions()
        {
            double result = Calculations.Multiplication(2 / 3, 5 / 4);
            Assert.AreEqual(0.83, result);
        }

        [TestMethod]
        public void MultipyNegativeFractions()
        {
            double result = Calculations.Addition(2 / 3, -5 / 4);
            Assert.AreEqual(-0.23, result);
        }
    }
}
