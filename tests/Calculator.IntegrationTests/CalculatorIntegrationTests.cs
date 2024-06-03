using Xunit;
using Calculator;

namespace Calculator.IntegrationTests
{
    public class CalculatorIntegrationTests
    {
        private readonly Calculator _calculator;

        public CalculatorIntegrationTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void PerformMultipleOperations_ReturnsExpectedResults()
        {
            // Act
            int result1 = _calculator.Add(2, 3);
            int result2 = _calculator.Subtract(10, 4);
            int result3 = _calculator.Multiply(3, 4);
            int result4 = _calculator.Divide(12, 3);

            // Assert
            Assert.Equal(5, result1);
            Assert.Equal(6, result2);
            Assert.Equal(12, result3);
            Assert.Equal(4, result4);

            var history = _calculator.GetOperationHistory();
            Assert.Equal(4, history.Count);
            Assert.Contains(5, history);
            Assert.Contains(6, history);
            Assert.Contains(12, history);
            Assert.Contains(4, history);
        }
    }
}