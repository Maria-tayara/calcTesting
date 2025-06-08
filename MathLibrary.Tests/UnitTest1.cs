using Xunit;
using MathLibrary;

namespace MathLibrary.Tests;


public class CalculatorTests
{
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange 


        int a = 2, b = 3;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_NumberWithZero_ReturnsZero()
    {
        // Arrange 
        int a = 0, b = 5;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
    {
        // Arrange 
        int a = -2, b = 3;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        // Arrange 
        int a = -2, b = -3;

        // Act 
        int result = Calculator.Multiply(a, b);

        // Assert 
        Assert.Equal(6, result);
    }
    // isEven Tests
    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        bool result = Calculator.IsEven(8);
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        bool result = Calculator.IsEven(7);
        Assert.False(result);
    }

    [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        bool result = Calculator.IsEven(0);
        Assert.True(result);
    }

    // Divide tests
    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        int result = Calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_NegativeAndPositive_ReturnsNegative()
    {
        int result = Calculator.Divide(-9, 3);
        Assert.Equal(-3, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(10, 0));
    }

    
}
