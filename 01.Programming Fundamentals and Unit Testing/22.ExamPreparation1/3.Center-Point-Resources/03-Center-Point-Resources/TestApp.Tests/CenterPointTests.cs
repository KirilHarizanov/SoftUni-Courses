using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double pointOneX =  1;
        double pointOneY =  1;
        double pointTwoX =  2;
        double pointTwoY =  2;


        // Act
        string result = CenterPoint.GetClosest(pointOneX, pointOneY, pointTwoX, pointTwoY);

        //Assert
        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double pointOneX = 2;
        double pointOneY = 2;
        double pointTwoX = 1;
        double pointTwoY = 1;


        // Act
        string result = CenterPoint.GetClosest(pointOneX, pointOneY, pointTwoX, pointTwoY);

        //Assert
        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double pointOneX = 1;
        double pointOneY = 1;
        double pointTwoX = 1;
        double pointTwoY = 1;


        // Act
        string result = CenterPoint.GetClosest(pointOneX, pointOneY, pointTwoX, pointTwoY);

        //Assert
        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double pointOneX = -1;
        double pointOneY = -1;
        double pointTwoX = 2;
        double pointTwoY = 2;


        // Act
        string result = CenterPoint.GetClosest(pointOneX, pointOneY, pointTwoX, pointTwoY);

        //Assert
        Assert.AreEqual("(-1, -1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double pointOneX = 1;
        double pointOneY = 1;
        double pointTwoX = -1;
        double pointTwoY = -1;


        // Act
        string result = CenterPoint.GetClosest(pointOneX, pointOneY, pointTwoX, pointTwoY);

        //Assert
        Assert.AreEqual("(-1, -1)", result);
    }
}
