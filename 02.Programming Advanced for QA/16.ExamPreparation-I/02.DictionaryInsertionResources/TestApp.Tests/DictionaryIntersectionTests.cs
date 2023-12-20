using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arange
        Dictionary<string, int> firsDictionary = new();
        Dictionary<string, int> secondDictionary = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firsDictionary, secondDictionary);
        

        // Assert
        Assert.That(result, Is.Empty);
        
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arange
        Dictionary<string, int> firsDictionary = new();
        Dictionary<string, int> secondDictionary = new() 
        {
            {"one", 1},
            {"two", 2},
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firsDictionary, secondDictionary);


        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arange
        Dictionary<string, int> firsDictionary = new()
        {
            {"one", 1},
            {"two", 2},
        };

        Dictionary<string, int> secondDictionary = new()
        {
            {"three", 3},
            {"four", 4},
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firsDictionary, secondDictionary);


        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arange
        Dictionary<string, int> firsDictionary = new()
        {
            {"one", 1},
            {"two", 2},
        };

        Dictionary<string, int> secondDictionary = new()
        {
            {"two", 2},
            {"four", 4},
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firsDictionary, secondDictionary);


        // Assert
        Assert.That(result.Count, Is.EqualTo(1));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arange
        Dictionary<string, int> firsDictionary = new()
        {
            {"one", 1},
            {"two", 2},
        };

        Dictionary<string, int> secondDictionary = new()
        {
            {"two", 3},
            {"four", 4},
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firsDictionary, secondDictionary);


        // Assert
        Assert.That(result, Is.Empty);
    }
}
