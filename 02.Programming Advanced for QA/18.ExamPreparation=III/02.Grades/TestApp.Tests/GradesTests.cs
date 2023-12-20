using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            ["Georgi"] = 5,
            ["Spas"] = 2,
            ["Nikolai"] = 4,
            ["Kiril"] = 6,
            ["Stavri"] = 3,
        };

        string expected = $"Kiril with average grade 6.00" +
            $"{Environment.NewLine}Georgi with average grade 5.00" +
            $"{Environment.NewLine}Nikolai with average grade 4.00";

        // Act
       string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new();

        string expected = string.Empty;

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            ["Georgi"] = 5,
            ["Kiril"] = 6,
        };

        string expected = $"Kiril with average grade 6.00" +
            $"{Environment.NewLine}Georgi with average grade 5.00";

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            ["Georgi"] = 5,
            ["Nikolai"] = 5,
            ["Kiril"] = 5,
        };

        string expected = $"Georgi with average grade 5.00" +
            $"{Environment.NewLine}Kiril with average grade 5.00" +
            $"{Environment.NewLine}Nikolai with average grade 5.00";

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
