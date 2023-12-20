using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arange
        string name = "Banana";
        double price = 100;
        int quantity = 10;

        string expected = $"Product Inventory:{Environment.NewLine}{name} - Price: ${price:f2} - Quantity: {quantity}";
   
        // Act
        this._inventory.AddProduct(name, price, quantity);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arange
        string expected = "Product Inventory:";

        // Act
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arange
        string name = "Banana";
        double price = 100;
        int quantity = 10;

        string nameTwo = "Coconut";
        double priceTwo = 150;
        int quantityTwo = 15;

        string expected = $"Product Inventory:{Environment.NewLine}{name} - Price: ${price:f2} - Quantity: {quantity}" +
            $"{Environment.NewLine}{nameTwo} - Price: ${priceTwo:f2} - Quantity: {quantityTwo}";

        // Act
        this._inventory.AddProduct(name, price, quantity);
        this._inventory.AddProduct(nameTwo, priceTwo, quantityTwo);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange

        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arange
        string name = "Banana";
        double price = 100;
        int quantity = 10;

        string nameTwo = "Coconut";
        double priceTwo = 150;
        int quantityTwo = 10;

        double expected = 2500;

        // Act
        this._inventory.AddProduct(name, price, quantity);
        this._inventory.AddProduct(nameTwo, priceTwo, quantityTwo);
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
