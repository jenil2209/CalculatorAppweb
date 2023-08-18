using Xunit;
using library;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void TestCalculate_Addition()
        {
            var calculator = new Calculator();
            string expression = "2 + 3";
            int result = calculator.Calculate(expression);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestCalculate_Subtraction()
        {
            var calculator = new Calculator();
            string expression = "7 - 4";
            int result = calculator.Calculate(expression);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestCalculate_Multiplication()
        {
            var calculator = new Calculator();
            string expression = "5 * 6";
            int result = calculator.Calculate(expression);
            Assert.Equal(30, result);
        }

        [Fact]
        public void TestCalculate_Division()
        {
            var calculator = new Calculator();
            string expression = "10 / 2";
            int result = calculator.Calculate(expression);
            Assert.Equal(5, result);
        }
 

        [Fact]
        public void TestCalculate_DivideByZero()
        {
            var calculator = new Calculator();
            string expression = "10 / 0";
            Assert.Throws<ArgumentException>(() => calculator.Calculate(expression));
        }

        [Fact]
        public void TestCalculate_InvalidExpression()
        {
            var calculator = new Calculator();
            string expression = "2 + ";
            Assert.Throws<ArgumentException>(() => calculator.Calculate(expression));
        }

     }
}
