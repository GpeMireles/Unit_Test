using Xunit;
using Moq;

namespace Calculators.TestMock {
    public class TestMockICalculator {
        [Fact]
        public void TestSeriesFibonacci() {
            // Arrange
            int n = 6;
            int expectFibb = 8;
            Mock<ICalculator> calculator = new Mock<ICalculator>(); // Simular interface ICalculator
            // Definicion del comportamiento del metodo Add() de ICalculator -> Devuelve la suma de los 2 parámetros de entrada
            calculator.Setup(o => o.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int first, int second) => first + second);
            Series series = new Series(calculator.Object);
            // Act
            int fibb;
            fibb = series.Fibonacci(n);
            // Assert
            Assert.Equal(expectFibb, fibb);
        }

        [Fact]
        public void TestSeriesFactorial() {
            // Arrange
            int n = 6;
            int expectFact = 720;
            Mock<ICalculator> calculator = new Mock<ICalculator>(); // Simular interface ICalculator
            // Definicion del comportamiento del metodo Mul() de ICalculator -> Devuelve la multiplicación de los 2 parámetros de entrada
            calculator.Setup(o => o.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns((int first, int second) => first * second);
            Series series = new Series(calculator.Object);
            // Act
            int fact;
            fact = series.Factorial(n);
            // Assert
            Assert.Equal(expectFact, fact);
        }

    }
}