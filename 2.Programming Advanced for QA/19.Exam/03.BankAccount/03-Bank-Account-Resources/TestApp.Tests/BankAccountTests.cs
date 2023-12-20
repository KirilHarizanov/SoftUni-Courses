using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 250.00;

        // Act
        BankAccount account = new BankAccount(initialBalance);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialBalance));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        BankAccount account = new BankAccount(250.00);
        double depositAmount = 50.00;

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(300.00));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(250.00);
        double depositAmount = -50.00;

        // Act & Assert
        Assert.That(() => account.Deposit(depositAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        BankAccount account = new BankAccount(250.00);
        double withdrawAmount = 50.00;

        // Act
        account.Withdraw(withdrawAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(200.00));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(250.00);
        double withdrawAmount = -50.00;

        // Act & Assert
        Assert.That(() => account.Withdraw(withdrawAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(250.00);
        double withdrawAmount = 300.00;

        // Act & Assert
        Assert.That(() => account.Withdraw(withdrawAmount), Throws.ArgumentException);
    }
}
