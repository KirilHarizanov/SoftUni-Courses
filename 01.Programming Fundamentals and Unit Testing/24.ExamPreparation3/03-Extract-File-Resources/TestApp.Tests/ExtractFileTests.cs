using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = "";

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Users\\User\\OneDrive\\Работен плот\\QA\\exam.txt";

        // Act 
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo("File name: exam\nFile extension: txt"));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = "C:\\Users\\User\\OneDrive\\Работен плот\\QA\\exam";

        // Act 
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo("File name: exam"));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Users\\User\\OneDrive\\Раб$$$отен плот\\QA\\e%am.txt";

        // Act 
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo("File name: e%am\nFile extension: txt"));
    }
}
