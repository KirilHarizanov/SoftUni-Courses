using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "X";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("X", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "XenoN";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("NoneX", actual);
    }
}
