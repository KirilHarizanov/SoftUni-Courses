using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] ints = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(ints);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] ints = { 1 };

        // Act
        string result = CountRealNumbers.Count(ints);

        // Assert
        Assert.That(result, Is.EqualTo("1 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] ints = { 1, 2, 2, 3, 3, 3 };

        // Act
        string result = CountRealNumbers.Count(ints);

        // Assert
        Assert.That(result, Is.EqualTo($"1 -> 1{Environment.NewLine}2 -> 2{Environment.NewLine}3 -> 3"));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] ints = { -1, -2, -2, -3, -3, -3 };

        // Act
        string result = CountRealNumbers.Count(ints);

        // Assert
        Assert.That(result, Is.EqualTo($"-3 -> 3{Environment.NewLine}-2 -> 2{Environment.NewLine}-1 -> 1"));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] ints = { 0, 0, 0};

        // Act
        string result = CountRealNumbers.Count(ints);

        // Assert
        Assert.That(result, Is.EqualTo($"0 -> 3"));
    }
}
