using System;
using System.Collections.Generic;
using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "Kiril";
        string message = "Hello!";

        // Act
        this._chatRoom.SendMessage(sender, message);
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain($"Chat Room Messages:{Environment.NewLine}Kiril: Hello! - Sent at "));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        List<ChatMessage> _chatMessages = new();

        // Act
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string sender = "Kiril";
        string message = "Hello!";
        string senderTwo = "Gosho";
        string messageTwo = "Hi!";

        // Act
        this._chatRoom.SendMessage(sender, message);
        this._chatRoom.SendMessage(senderTwo, messageTwo);
        string result = this._chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain($"Chat Room Messages:{Environment.NewLine}Kiril: Hello! - Sent at "));
        Assert.That(result, Does.Contain("Gosho: Hi! - Sent at "));
    }
}
