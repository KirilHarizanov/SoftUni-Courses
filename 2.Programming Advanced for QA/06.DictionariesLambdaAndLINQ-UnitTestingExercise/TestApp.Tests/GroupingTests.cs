using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new ();

        // Act
        string result = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4, 5 };

        // Act
        string result = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(result, Is.EqualTo($"Odd numbers: 1, 3, 5{Environment.NewLine}Even numbers: 2, 4"));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 2, 4, 6 };

        // Act
        string result = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 4, 6"));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 1, 3, 5 };

        // Act
        string result = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 3, 5"));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { -1, -2, -3, -4, -5 };

        // Act
        string result = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(result, Is.EqualTo($"Odd numbers: -1, -3, -5{Environment.NewLine}Even numbers: -2, -4"));
    }
}
