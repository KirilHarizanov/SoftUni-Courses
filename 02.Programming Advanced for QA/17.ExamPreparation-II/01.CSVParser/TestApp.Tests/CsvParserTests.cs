using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = "";

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "Hello";

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output, Is.EqualTo(new[] { "Hello" }));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "Hello,how,are,you";

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output, Is.EqualTo(new[] { "Hello", "how", "are", "you" }));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "   Hello , how  ,   are,you                 ";

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output, Is.EqualTo(new[] { "Hello", "how", "are", "you" }));
    }
}
