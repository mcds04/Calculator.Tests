using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectResult()
        {
            int result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectResult()
        {
            int result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectResult()
        {
            int result = _calculator.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectResult()
        {
            int result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<System.DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}