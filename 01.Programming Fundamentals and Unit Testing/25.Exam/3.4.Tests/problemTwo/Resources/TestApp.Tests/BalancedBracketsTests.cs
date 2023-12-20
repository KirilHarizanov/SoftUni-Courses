using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        // Arrange
        string[] brackets = { };

        // Act
        bool output = BalancedBrackets.IsBalanced(brackets);

        // Assert
        Assert.IsTrue(output);

    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        // Arrange
        string[] brackets = {"(", ")","(", ")"};

        // Act
        bool output = BalancedBrackets.IsBalanced(brackets);

        // Assert
        Assert.IsTrue(output);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] brackets = { "(", ")", "(", "" };

        // Act
        bool output = BalancedBrackets.IsBalanced(brackets);

        // Assert
        Assert.IsFalse(output);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] brackets = { "(", ")", "(", "))" };

        // Act
        bool output = BalancedBrackets.IsBalanced(brackets);

        // Assert
        Assert.IsFalse(output);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] brackets = { "(", "", "(", "" };

        // Act
        bool output = BalancedBrackets.IsBalanced(brackets);

        // Assert
        Assert.IsFalse(output);
    }

    [Test]
    public void Test_IsBalanced_NoOpeningBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] brackets = { "", ")", "", ")" };

        // Act
        bool output = BalancedBrackets.IsBalanced(brackets);

        // Assert
        Assert.IsFalse(output);
    }
}
