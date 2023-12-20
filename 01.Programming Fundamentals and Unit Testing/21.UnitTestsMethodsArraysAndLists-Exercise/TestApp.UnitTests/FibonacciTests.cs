using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int n = 0;

        // Act
        int actual = Fibonacci.CalculateFibonacci(n);

        // Assert
        Assert.AreEqual(n, actual);

    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int n = 7;

        // Act
        int actual = Fibonacci.CalculateFibonacci(n);

        // Assert
        Assert.AreEqual(13, actual);
    }
}