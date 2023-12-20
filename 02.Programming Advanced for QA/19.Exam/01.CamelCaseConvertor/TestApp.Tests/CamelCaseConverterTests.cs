using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo(""));

    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "Word";

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo("word"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "words to convert";

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo("wordsToConvert"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "Words to Convert";

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo("wordsToConvert"));
    }
}
