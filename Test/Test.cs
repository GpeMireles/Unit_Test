using Calculators;
using Xunit;

namespace Test {
    public class CalculatorShould {
        [Fact]
        public void AddTwoNumbers() {
            // Arrange
            Calculator calculator = new Calculator();
            float a = 10f, b = 20f;

            // Act
            float add = calculator.Add(a, b);

            // Assert
            Assert.Equal(30f, add);
        }

        [Fact]
        public void SubsTwoNumbers() {
            // Arrange
            Calculator calculator = new Calculator();
            float a = 3.2f, b = 1.2f;

            // Act
            float sub = calculator.Sub(a, b);
            
            // Assert
            Assert.Equal(2f, sub);
        }

        [Theory]
        [InlineData(1.5f, 5f, 7.5f)]
        [InlineData(0f, 6f, 0f)]
        [InlineData(-2f, 5.1f, -10.2f)]
        [InlineData(-3.0f, -2.1f, 6.3f)] // Falla por la precisión de la multiplicación de punto flotante
        [InlineData(7.5f, 2f, 15f)]
        public void MulTiplyTwoNumbers(float a, float b, float res) {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            float mul = calculator.Mul(a, b);

            // Assert
            Assert.Equal(res, mul);
        }

        [Theory]
        [InlineData(1.5f, 3f, 0.5f)]
        [InlineData(10f, 7f, 10.0 / 7.0)]
        [InlineData(-5, 2.5f, -2f)]
        [InlineData(-8f, -64f, 0.125f)]
        [InlineData(33f, 11f, 3f)]
        public void DivideTwoNumbers(float a, float b, float res) {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            float div = calculator.Div(a, b);
            
            // Assert
            Assert.Equal(res, div);
        }

        [Theory]
        [InlineData(5.2, 0f)]
        public void TestingThrowErrorDivByZero(float a, float b) {
            // Arrange
            Calculator calculator = new Calculator();

            // Assert ( Act )
            Assert.Throws<DivideByZeroException>(() => calculator.Div(a, b));
        }

    }
}