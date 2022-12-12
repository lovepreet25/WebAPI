using CalculationLibrary1;

namespace CalculatorTests
{
    [TestClass]
    public class SubtractionTests

    {
        [TestMethod]
        public void SubDiffInteger()
        {
            double result = Calculations.Subtraction(3, 4);
            Assert.AreEqual(7, result);

        }
        [TestMethod]
        public void SubSameInteger()
        {
            double result = Calculations.Subtraction(4, 4);
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        public void SubTPositiveInnteger()
        {
            double result = Calculations.Subtraction(50, 4);
            Assert.AreEqual(46, result);

        }
        [TestMethod]
        public void SubnegativeInt()
        {
            double result = Calculations.Subtraction(-3, -4);
            Assert.AreEqual(-7, result);

        }
        [TestMethod]
        public void SubdifferentSignInt()
        {
            double result = Calculations.Subtraction(-3, 4);
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void SubDecimalNumbers()
        {
            double result = Calculations.Subtraction(0.3, 0.04);
            Assert.AreEqual(0.34, result);

        }
        [TestMethod]
        public void SubNegativeDecimalNumbers()
        {
            double result = Calculations.Subtraction(0.3, -0.04);
            Assert.AreEqual(0.34, result);

        }
        [TestMethod]
        public void SubAZero()
        {
            double result = Calculations.Subtraction(0.3, 0.0);
            Assert.AreEqual(0.3, result);
        }
        [TestMethod]
        public void SubFractions()
        {
            double result = Calculations.Subtraction(2 / 3, 5 / 4);
            Assert.AreEqual(0.3, result);
        }

        [TestMethod]
        public void SubNegativeFractions()
        {
            double result = Calculations.Subtraction(2 / 3, -5 / 4);
            Assert.AreEqual(-0.3, result);
        }
    }
}
