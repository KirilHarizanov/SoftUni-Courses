using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char start = 'A';
        char end = 'B';

        // Act
        string output = CharacterRange.GetRange(start, end);

        // Assert
        Assert.That(output, Is.EqualTo(""));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char start = 'B';
        char end = 'A';

        // Act
        string output = CharacterRange.GetRange(start, end);

        // Assert
        Assert.That(output, Is.EqualTo(""));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char start = 'A';
        char end = 'C';

        // Act
        string output = CharacterRange.GetRange(start, end);

        // Assert
        Assert.That(output, Is.EqualTo("B"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char start = 'D';
        char end = 'G';

        // Act
        string output = CharacterRange.GetRange(start, end);

        // Assert
        Assert.That(output, Is.EqualTo("E F"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char start = 'X';
        char end = 'Z';

        // Act
        string output = CharacterRange.GetRange(start, end);

        // Assert
        Assert.That(output, Is.EqualTo("Y"));
    }
}
