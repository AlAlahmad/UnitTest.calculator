using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.calculator
{
    [TestFixture]
    public class CalculatorTests
    {
        [Fact]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Xunit.Assert.Equal(8, calculator.Multiplication(2, 4));
        }

        [Fact]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Xunit.Assert.True(calculator.Subtraction(2, 4) == -2);
        }

        [Fact]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Xunit.Assert.True(calculator.Division(2, 4) == 0);
        }

        [Fact]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();

            Xunit.Assert.Throws<DivideByZeroException>(() => calculator.Division(2, 0));
        }

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();

        }
    }
}
    }
}
