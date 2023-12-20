using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long n = -2;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => { PrimeFactor.FindLargestPrimeFactor(n); });
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long n = 5;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.AreEqual(n, result);

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long n = 123456789123456789;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.AreEqual(52579, result);
    }
}
