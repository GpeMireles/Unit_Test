using Calculators;
using Xunit;
using Moq;

namespace TestMock {
    public class TestMockICalculator {
        [Fact]
        public void TestSeriesFibonacci() {
            int n = 6;
            int expectFibb = 8;
            Mock<ICalculator> calculator = new Mock<ICalculator>();

            calculator.Setup(o => o.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int first, int second) => first + second);

            Series series = new Series(calculator.Object);
            int fibb;
            fibb = series.Fibonacci(n);
            Assert.Equal(expectFibb, fibb);
        }

        [Fact]
        public void TestSeriesFactorial() {
            int n = 6;
            int expectFact = 720;
            Mock<ICalculator> calculator = new Mock<ICalculator>();

            calculator.Setup(o => o.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns((int first, int second) => first * second);

            Series series = new Series(calculator.Object);
            int fact;
            fact = series.Factorial(n);
            Assert.Equal(expectFact, fact);
        }

    }
}