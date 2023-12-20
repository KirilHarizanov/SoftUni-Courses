using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    [TestCase(new int[] { 1, 2, 3, 4 }, "3 7")]
    [TestCase(new int[] { }, "")]
    [TestCase(new int[] { 2, 2, 2, 2}, "4 4")]
    [TestCase(new int[] { 0, 0, 0, 0 }, "0 0")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Arange

        // Act
        string result = FoldSum.FoldArray(arr);

        // Assert
        Assert.AreEqual(expected, result);
    }
}