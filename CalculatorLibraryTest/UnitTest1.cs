using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibraryTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            int a = 5;
            int b = 3;
            int expectedResult = 8;

            int actualResult = Calculator.Add(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            int a = 4;
            int b = 2;
            int expectedResult = 2;

            int actualResult = Calculator.Subtract(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            int a = 3;
            int b = 5;
            int expectedResult = 15;

            int actualResult = Calculator.Multiply(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivision()
        {
            int a = 8;
            int b = 2;
            int expectedResult = 4;

            int actualResult = Calculator.Divide(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
