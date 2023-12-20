using NUnit.Framework;

using System;
using System.Numerics;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = { "banana" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 6 letters:{Environment.NewLine}banana"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = { "banana", "tomato", "tree", "olive" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}tree{Environment.NewLine}" +
            $"Plants with 5 letters:{Environment.NewLine}olive{Environment.NewLine}" +
            $"Plants with 6 letters:{Environment.NewLine}banana{Environment.NewLine}tomato"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = { "Banana", "tomato", "Tree", "olive" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}Tree{Environment.NewLine}" +
            $"Plants with 5 letters:{Environment.NewLine}olive{Environment.NewLine}" +
            $"Plants with 6 letters:{Environment.NewLine}Banana{Environment.NewLine}tomato"));
    }
}
