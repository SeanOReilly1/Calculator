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
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDiv()
        {
            //Assemble
            Calculator calc = new Calculator();
            int expected = 2;
            int expectedWith0 = 10;

            //Act
            int ActualResult = calc.Div(10, 5);
            int ActualResultWith0 = calc.Div(10, 0);

            //Assert
            Assert.AreEqual(expected, ActualResult);
            Assert.AreEqual(expectedWith0, ActualResultWith0);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMod()
        {
            //Assemble
            Calculator calc = new Calculator();
            int expected = 2;
            int expectedWith0 = 10;
            //int expectedWithNegative = -50;

            //Act
            int actualResult = calc.Mod(5, 3);
            int actualResultWith0 = calc.Mod(10, 0);
            //int actualResultWithNegative = calc.Mul(10, -5);

            //Assert
            Assert.AreEqual(expected, actualResult);
            Assert.AreEqual(expectedWith0, actualResultWith0);
           // Assert.AreEqual(expectedWithNegative, actualResultWithNegative);
        }


        [TestMethod]
        public void TestPow()
        {
            //Assemble
            Calculator calc = new Calculator();
            double expected = 4;
            double expectedWith0 = 1;
            double expectedWithNegPower = 0.125;

            //Act
            double actualResult = calc.Power(2, 2);
            double actualResultWith0 = calc.Power(2, 0);
            double actualResultWithNegPower = calc.Power(2, -3);

            //Assert
            Assert.AreEqual(expected, actualResult);
            Assert.AreEqual(expectedWith0, actualResultWith0);
            Assert.AreEqual(expectedWithNegPower, actualResultWithNegPower);
        }

        [TestMethod]
        public void TestSqrt()
        {
            //Assemble
            Calculator calc = new Calculator();
            double expected = 7;
            double expectedWithNegative = double.NaN;
            double expectedWith0 = 0;

            //Act
            double actualResult = calc.Sqrt(49);
            double actualResultWithNegative = calc.Sqrt(-49);
            double actualResultWith0 = calc.Sqrt(0);

            //Assert
            Assert.AreEqual(expected, actualResult);
            Assert.AreEqual(expectedWithNegative, actualResultWithNegative);
            Assert.AreEqual(expectedWith0, actualResultWith0);
        }
    }
}
