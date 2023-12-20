using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arange
        string input = string.Empty;

        int positions = 2;

        // Act
        string output = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(input, output);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arange
        string input = "Hello";

        int positions = 0;

        // Act
        string output = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(input, output);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arange
        string input = "Hello";

        int positions = 2;

        // Act
        string output = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(output, Is.EqualTo("loHel"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arange
        string input = "Hello";

        int positions = -2;

        // Act
        string output = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(output, Is.EqualTo("loHel"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arange
        string input = "Hello";

        int positions = input.Length + 2;

        // Act
        string output = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(output, Is.EqualTo("loHel"));
    }
}
