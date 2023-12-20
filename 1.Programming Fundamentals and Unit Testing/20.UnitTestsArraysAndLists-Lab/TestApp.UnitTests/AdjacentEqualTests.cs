using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { AdjacentEqual.Sum(nullList); });
    }

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 2, 2, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(result, Is.EqualTo("1 4 3 4 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 1, 2, 4 };

        // Act
        string result = AdjacentEqual.Sum(ints);

        // Assert
        Assert.AreEqual("8", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 1, 2, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(ints);

        // Assert
        Assert.AreEqual("8 5", result);
    } 

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 1, 2, 4, 4 };

        // Act
        string result = AdjacentEqual.Sum(ints);

        // Assert
        Assert.AreEqual("8 4", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 2, 3, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(ints);

        // Assert
        Assert.AreEqual("1 2 6 4 5", result);
    }
}
