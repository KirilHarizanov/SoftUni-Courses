using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> word = new List<string>() { "aha" };

        // Act
        bool result = Palindrome.IsPalindrome(word);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> word = new List<string>() { "ahaha" };

        // Act
        bool result = Palindrome.IsPalindrome(word);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> word = new List<string>() { "ahahah" };

        // Act
        bool result = Palindrome.IsPalindrome(word);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> word = new List<string>() { "AhAhA" };

        // Act
        bool result = Palindrome.IsPalindrome(word);

        // Assert
        Assert.IsTrue(result);
    }
}
