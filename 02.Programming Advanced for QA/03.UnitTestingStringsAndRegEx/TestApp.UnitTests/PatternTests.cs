using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("police", 2, "pOlIcEpOlIcE")]
    [TestCase("police", 1, "pOlIcE")]
    [TestCase("police", 3, "pOlIcEpOlIcEpOlIcE")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repetitionFactor = 2;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "cat";
        int repetitionFactor = -2;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "dog";
        int repetitionFactor = 0;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
}
