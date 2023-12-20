using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[] input = null;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => { Fake.RemoveStringNumbers(input); });
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] chars = new char[] { '0', '1', 'a', 'b' };

        // Act
        char[] result = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b' }));

    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] chars = new char[] { 'a', 'b' };

        // Act
        char[] result = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] chars = new char[] { };

        // Act
        char[] result = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { }));
    }

    [Test]
    public void Test_RemoveStringNumbers_OnlyDigits_ReturnsEmptyArray()
    {
        // Arrange
        char[] chars = new char[] { '1', '2', '3' };

        // Act
        char[] result = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { }));
    }
}