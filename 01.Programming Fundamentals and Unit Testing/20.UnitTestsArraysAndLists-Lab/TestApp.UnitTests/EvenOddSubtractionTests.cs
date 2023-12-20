using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] EvenSum = new int[3] { 2, 8, 10 };

        // Act
        int result = EvenOddSubtraction.FindDifference(EvenSum);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnOddSum()
    {
        // Arrange
        int[] OddSum = new int[2] { 3, 17 };

        // Act
        int result = EvenOddSubtraction.FindDifference(OddSum);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] Difference = new int[3] { 1, 2, 3};

        // Act
        int result = EvenOddSubtraction.FindDifference(Difference);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
