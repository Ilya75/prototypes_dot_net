using IoC.PrototypeOne.ClassLibrary;
using System;
using Xunit;

namespace IoC.PrototypeOne.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Assert_Addition_Works()
        {
            // arrange
            var calc = Container.Instance.Resolve<ICalculator<double>>();

            // act
            var result = calc.Add(5, 1);

            // assert
            Assert.Equal(6, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 10, 2)]
        public void Assert_Multiplication_Works(double result, double one, double two)
        {
            // arrange
            var calc = Container.Instance.Resolve<ICalculator<double>>();

            // act and assert
            Assert.Equal(result, calc.Multiply(one, two));
        }
    }
}
