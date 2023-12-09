using System;
using FluentAssertions;
using Xunit;

namespace SimpleCalculatorApp2.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, 3, 8)]
        public void Calculator_Add_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeGreaterOrEqualTo(8);
            result.Should().NotBe(null);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(30, 200, -170)]
        public void Calculator_Subtract_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Subtract(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeLessOrEqualTo(8);
            result.Should().NotBe(null);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        public void Calculator_Multiply_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Multiply(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeLessOrEqualTo(20);
            result.Should().NotBe(null);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(5, 1, 5)]
        public void Calculator_Divide_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Divide(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeGreaterOrEqualTo(5);
            result.Should().NotBe(null);
        }

        [Theory]
        [InlineData(2, 0)]
        public void Calculator_Divide_ReturnDivideByZeroException(int a, int b)
        {
            // Arrange 
            var calculator = new Calculator();

            // Act + Assert
            Action action = () => calculator.Divide(a, b);
            action.Should().NotBeNull();
            action.Should().Throw<DivideByZeroException>();
        }
    }
}