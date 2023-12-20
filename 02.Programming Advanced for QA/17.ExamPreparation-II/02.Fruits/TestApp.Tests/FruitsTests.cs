using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitsQuantity = new()
        {
            ["banana"] = 10
        };

        string fruit = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruitsQuantity, fruit);

        // Assert
        Assert.That(result, Is.EqualTo(10));

    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsQuantity = new()
        {
            ["banana"] = 10
        };

        string fruit = "strawberry";

        // Act
        int result = Fruits.GetFruitQuantity(fruitsQuantity, fruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsQuantity = new();

        string fruit = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruitsQuantity, fruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsQuantity = null;

        string fruit = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruitsQuantity, fruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsQuantity = new()
        {
            ["banana"] = 10
        };

        string fruit = null;

        // Act
        int result = Fruits.GetFruitQuantity(fruitsQuantity, fruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}
