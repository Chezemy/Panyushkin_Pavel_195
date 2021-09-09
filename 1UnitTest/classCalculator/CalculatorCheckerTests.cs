using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorCheckerTests
    {
        //Test of +

        [TestMethod()]
        public void CheckAddition_ReturnsTrue()
        {
            // Arrange
            double num1 = 4;
            double num2 = 6;
            double result = 10;
            string operation = "+";
            bool expected = true;
            // Act
            bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckAddition_ReturnsFalse()
        {
            // Arrange
            double num1 = 7;
            double num2 = 5;
            double result = 15;
            string operation = "+";
            bool expected = false;
            // Act
            bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test of "-"

        [TestMethod()]
        public void CheckSubtraction_ReturnsTrue()
        {
            // Arrange
            double num1 = 53;
            double num2 = 8;
            double result = 45;
            string operation = "-";
            bool expected = true;
            // Act
            bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckSubtraction_ReturnsFalse()
        {
            // Arrange
            double num1 = 25;
            double num2 = 15;
            double result = 11;
            string operation = "-";
            bool expected = false;
            // Act
            bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Test of "*"

        [TestMethod()]
        public void CheckMultiply_ReturnsTrue()
        {
                // Arrange
                double num1 = 5;
                double num2 = 8;
                double result = 40;
                string operation = "*";
                bool expected = true;
                // Act
                bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
                // Assert
                Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckMultiply_ReturnsFalse()
        {
                // Arrange
                double num1 = 7;
                double num2 = 3;
                double result = 15;
                string operation = "*";
                bool expected = false;
                // Act
                bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
                // Assert
                Assert.AreEqual(expected, actual);
        }


        //Test of "/"

        [TestMethod()]
        public void CheckDivide_ReturnsTrue()
        {
                // Arrange
                double num1 = 60;
                double num2 = 2;
                double result = 30;
                string operation = "/";
                bool expected = true;
                // Act
                bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
                // Assert
                Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckDivide_ReturnsFalse()
        {
            // Arrange
            double num1 = 75;
            double num2 = 5;
            double result = 30;
            string operation = "+";
            bool expected = false;
            // Act
            bool actual = CalculatorChecker.validateOperation(num1, num2, operation, result);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}