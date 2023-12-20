using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] nums = null;

        // Act + Assert
        Assert.That(() => LongestIncreasingSubsequence.GetLis(nums), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] nums = new int[] { };

        // Act
        string output = LongestIncreasingSubsequence.GetLis(nums);

        // Assert
        Assert.That(output, Is.EqualTo(new int[] { }));

    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] nums = new int[] { 1 };

        // Act
        string output = LongestIncreasingSubsequence.GetLis(nums);

        // Assert
        Assert.That(output, Is.EqualTo("1"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] nums = new int[] { 1, 3, 2, 1 };

        // Act
        string output = LongestIncreasingSubsequence.GetLis(nums);

        // Assert
        Assert.That(output, Is.EqualTo("1 3"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] nums = new int[] { 1, 3, 4, 5, 2, 1 };

        // Act
        string output = LongestIncreasingSubsequence.GetLis(nums);

        // Assert
        Assert.That(output, Is.EqualTo("1 3 4 5"));
    }
}
