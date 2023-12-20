using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arange
        string taskName = "my first task";
        DateTime taskDate = DateTime.Today;

        // Act
        this._toDoList.AddTask(taskName, taskDate);
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[ ] my first task - Due:"));

    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arange
        string taskName = "task to complete";
        DateTime taskDate = DateTime.Today;

        // Act
        this._toDoList.AddTask(taskName, taskDate);
        this._toDoList.CompleteTask(taskName);

        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[✓] task to complete - Due:"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arange
        string taskName = "task to complete";

        // Act & Assert
        Assert.That(() => this._toDoList.CompleteTask(taskName), Throws.ArgumentException);

    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo("To-Do List:"));

    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arange
        string taskName = "my first task";
        DateTime taskDate = DateTime.Today;
        string taskNameTwo = "task to complete";
        DateTime taskDateTwo = DateTime.Today;


        // Act
        this._toDoList.AddTask(taskName, taskDate);
        this._toDoList.AddTask(taskNameTwo, taskDateTwo);
        this._toDoList.CompleteTask(taskNameTwo);

        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[ ] my first task - Due:"));
        Assert.That(result, Does.Contain("[✓] task to complete - Due:"));
    }
}
