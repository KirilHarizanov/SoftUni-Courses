using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int input = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int input = 5;
        Dictionary<int, int> expected = new Dictionary<int, int>() 
        {
            [5] = 1
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = 555233;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [5] = 3,
            [2] = 1,
            [3] = 2
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = -555233;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            [5] = 3,
            [2] = 1,
            [3] = 2
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
