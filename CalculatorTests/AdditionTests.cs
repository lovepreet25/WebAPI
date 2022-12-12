using CalculationLibrary1;

namespace CalculatorTests
{
    [TestClass]
    public class AdditionTests

    {
        [TestMethod]
        public void AddDiffInteger()
        {
            double result = Calculations.Addition(3, 4);
            Assert.AreEqual(7, result);

        }
        [TestMethod]
        public void AddSameInteger()
        {
            double result = Calculations.Addition(4, 4);
            Assert.AreEqual(8, result);

        }
        [TestMethod]
        public void AddTPositiveInnteger()
        {
            double result = Calculations.Addition(50, 4);
            Assert.AreEqual(50, result);

        }
        [TestMethod]
        public void AddnegativeInt()
        {
            double result = Calculations.Addition(-3, -4);
            Assert.AreEqual(7, result);

        }
        [TestMethod]
        public void AdddifferentSignInt()
        {
            double result = Calculations.Addition(-3, 4);
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void AddDecimalNumbers()
        {
            double result = Calculations.Addition(0.3, 0.04);
            Assert.AreEqual(0.34, result);

        }
        [TestMethod]
        public void AddNegativeDecimalNumbers()
        {
            double result = Calculations.Addition(0.3, -0.04);
            Assert.AreEqual(0.34, result);

        }
        [TestMethod]
        public void AddAZero()
        {
            double result = Calculations.Addition(0.3, 0.0);
            Assert.AreEqual(0.3, result);
        }
        [TestMethod]
        public void AddFractions()
        {
            double result = Calculations.Addition(2 / 3, 5 / 4);
            Assert.AreEqual(0.3, result);
        }

        [TestMethod]
        public void AddNegativeFractions()
        {
            double result = Calculations.Addition(2 / 3, -5 / 4);
            Assert.AreEqual(-0.3, result);
        }
        
    }
}
