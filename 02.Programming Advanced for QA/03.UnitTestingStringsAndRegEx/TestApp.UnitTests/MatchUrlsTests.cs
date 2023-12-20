using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new List<string>();

        // Act
        List<string> output = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "jfdjfojbkoebkkkdpkwp  kwpkp ki0w 9- 769w8e56e46";
        List<string> expected = new List<string>();

        // Act
        List<string> output = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "http://softuni.bg";
        List<string> expected = new List<string>() { "http://softuni.bg" };

        // Act
        List<string> output = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "http://softuni.bg lsf ouh 67 https://www.abc.com ldsm /http://github.gov";
        List<string> expected = new List<string>() { "http://softuni.bg", "https://www.abc.com", "http://github.gov" };

        // Act
        List<string> output = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "\"http://softuni.bg\" lsf \"https://www.abc.com\" 145";
        List<string> expected = new List<string>() { "http://softuni.bg", "https://www.abc.com" };

        // Act
        List<string> output = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
