using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenList = new List<int>() { 1, 2, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenList);

        // Assert
        List<int> assertionList = new List<int>() { 5, 5 };
        CollectionAssert.AreEqual (assertionList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddList = new List<int>() { 1, 2, 3, 4, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(oddList);

        // Assert
        List<int> assertionList = new List<int>() { 6, 6, 3 };
        CollectionAssert.AreEqual(assertionList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenList);

        // Assert
        List<int> assertionList = new List<int>() { 11, 11, 11, 11, 11 };
        CollectionAssert.AreEqual(assertionList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> EvenList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        // Act
        List<int> result = GaussTrick.SumPairs(EvenList);

        // Assert
        List<int> assertionList = new List<int>() { 12, 12, 12, 12, 12, 6 };
        CollectionAssert.AreEqual(assertionList, result);
    }
}
