using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { MaxNumber.FindMax(nullList); });
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { MaxNumber.FindMax(emptyList); });
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> oneElementList = new List<int>() { 5 };

        // Act
        int element = MaxNumber.FindMax(oneElementList);

        // Assert
        Assert.AreEqual(5, element);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveElementsList = new List<int>() { 1, 2, 3, 4, 5 };

        // Act
        int element = MaxNumber.FindMax(positiveElementsList);

        // Assert
        Assert.AreEqual(5, element);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeElementsList = new List<int>() { -1, -2, -3, -4, -5 };

        // Act
        int element = MaxNumber.FindMax(negativeElementsList);

        // Assert
        Assert.AreEqual(-1, element);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedElementsList = new List<int>() { 1, -2, 3, -4, 5 };

        // Act
        int element = MaxNumber.FindMax(mixedElementsList);

        // Assert
        Assert.AreEqual(5, element);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> duplicateElementsList = new List<int>() { 5, 1, 2, 3, 4, 5 };

        // Act
        int element = MaxNumber.FindMax(duplicateElementsList);

        // Assert
        Assert.AreEqual(5, element);
    }
}
