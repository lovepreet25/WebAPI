using CalculationLibrary1;
// 10 Dividation Tests
namespace CalculatorTests
{
    [TestClass]
    public class DividationTests

    {
        [TestMethod]
        public void DivideDiffInteger()
        {
            double result = Calculations.Dividation(3, 4);
            Assert.AreEqual(0.75, result);

        }
        [TestMethod]
        public void DivideSameInteger()
        {
            double result = Calculations.Dividation(4, 4);
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void DivideTPositiveInnteger()
        {
            double result = Calculations.Dividation(40, 4);
            Assert.AreEqual(40, result);

        }
        [TestMethod]
        public void DividenegativeInt()
        {
            double result = Calculations.Dividation(-3, -4);
            Assert.AreEqual(-0.75, result);

        }
        [TestMethod]
        public void DividedifferentSignInt()
        {
            double result = Calculations.Dividation(-3, 4);
            Assert.AreEqual(-0.75, result);

        }
        [TestMethod]
        public void DivideDecimalNumbers()
        {
            double result = Calculations.Dividation(0.3, 0.04);
            Assert.AreEqual(7.5, result);

        }
        [TestMethod]
        public void DivideNegativeDecimalNumbers()
        {
            double result = Calculations.Dividation(0.3, -0.04);
            Assert.AreEqual(0.34, result);

        }


        [TestMethod]
        public void DivideFractions()
        {
            double result = Calculations.Dividation(2 / 3, 5 / 4);
            Assert.AreEqual(0.3, result);
        }

        [TestMethod]
        public void DivideNegativeFractions()
        {
            double result = Calculations.Dividation(2 / 3, -5 / 4);
            Assert.AreEqual(-0.3, result);
        }
        [TestMethod]
        public void DivideByZeroException()
        {
            Assert.ThrowsException<DivideByZeroException>(() => CalculationLibrary1.Calculations.Dividation(2, 0));

        }
    }
}
