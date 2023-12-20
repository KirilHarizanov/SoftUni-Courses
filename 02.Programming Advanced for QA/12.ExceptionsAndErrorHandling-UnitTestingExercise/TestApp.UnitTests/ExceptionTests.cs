using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "DOG";
        string expected = "GOD";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal price = 100;
        decimal discount = 10;
        decimal expected = 90;

        // Act
        decimal output = this._exceptions.ArgumentCalculateDiscount(price, discount);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 100;
        decimal discount = -10;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(price, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] numbers = { 1, 2, 3 };
        int index = 2;

        // Act
        int result = this._exceptions.IndexOutOfRangeGetElement(numbers, index);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] numbers = { 1, 2, 3 };
        int index = -2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(numbers, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoggedIn = true;

        // Act 
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        // Assert
        Assert.That(result, Is.EqualTo("User logged in."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoggedIn = false;

        // Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.InvalidOperationException);
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "6";

        // Act
        int result = this._exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "text";

        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>()
        {
            ["text"] = 10,
            ["textx"] = 155,
            ["textxt"] = 12,
        };

        string key = "text";
        //Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(keyValuePairs, key);

        //Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>()
        {
            ["text"] = 10,
            ["textx"] = 155,
            ["textxt"] = 12,
        };

        string key = "texttext";
        //Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(keyValuePairs, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int numOne = 2;
        int numTwo = 3;

        // Act
        int result = this._exceptions.OverflowAddNumbers(numOne, numTwo);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int numOne = int.MaxValue;
        int numTwo = int.MaxValue;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(numOne, numTwo), Throws.InstanceOf<OverflowException>()); 
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int numOne = int.MinValue;
        int numTwo = int.MinValue;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(numOne, numTwo), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int numOne = 6;
        int numTwo = 3;

        // Act
        int result = this._exceptions.DivideByZeroDivideNumbers(numOne, numTwo);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int numOne = 6;
        int numTwo = 0;

        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(numOne, numTwo), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = { 1, 2, 3, 4, 5 };
        int index = 3;

        // Act
        int result = this._exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    { 
        // Arrange
        int[] collection = null;
        int index = 2;

        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = { 1, 2, 3, 4, 5 };
        int index = 5;

        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
        {
            ["ten"] = "10"

        };

        string key = "ten";
        //Act
        int result = this._exceptions.GetElementAsNumber(keyValuePairs, key);

        //Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
        {
            ["ten"] = "10"

        };

        string key = "six";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(keyValuePairs, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
        {
            ["ten"] = "ten10"

        };

        string key = "ten";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(keyValuePairs, key), Throws.InstanceOf<FormatException>());
    }
}
