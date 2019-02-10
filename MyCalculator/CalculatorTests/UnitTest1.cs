using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
           //Assemble
           Calculator calc = new Calculator();
           int expected = 5;
           int expectedWithNegative = -1;

           //Act
           int actualResult = calc.Add(2, 3);
           int actualResultWithNegative = calc.Add(2, -3);

           //Assert
           Assert.AreEqual(expected, actualResult);
           Assert.AreEqual(expectedWithNegative, actualResultWithNegative);

        }

        [TestMethod]
        public void TestSub()
        {
            //Assemble
            Calculator calc = new Calculator();
            int expected = 5;
            int expectedWithNegative = 15;

            //Act
            int actualResult = calc.Sub(10, 5);
            int actualResultWithNegative = calc.Sub(10, -5);

            //Assert
            Assert.AreEqual(expected, actualResult);
            Assert.AreEqual(expectedWithNegative, actualResultWithNegative);
        }

        [TestMethod]
        public void TestMul()
        {
            //Assemble
            Calculator calc = new Calculator();
            int expected = 50;
            int expectedWith0 = 0;
            int expectedWithNegative = -50;

            //Act
            int actualResult = calc.Mul(10, 5);
            int actualResultWith0 = calc.Mul(10, 0);
            int actualResultWithNegative = calc.Mul(10, -5);

            //Assert
            Assert.AreEqual(expected, actualResult);
            Assert.AreEqual(expectedWith0, actualResultWith0);
            Assert.AreEqual(expectedWithNegative, actualResultWithNegative);
        }

        

        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void TestDiv()
        {
            //Assemble
            Calculator calc = new Calculator();
            int expected = 2;

            //Act
            int ActualResult = calc.Div(10, 5);

            //Assert
            Assert.AreEqual(expected, ActualResult);
        }
    }
}
