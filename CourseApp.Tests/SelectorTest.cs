namespace CourseApp.Tests;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CourseApp.Logger;
using CourseApp.SelectorGame;
using Xunit;

[Collection("Sequential")]
public class SelectorTest
{
    [Theory]
    [InlineData("1", "Да", "Да")]
    [InlineData("2", "Да", "Да")]
    [InlineData("3", "Да", "Да")]
    public void SelectCustomClassTest(string number, string isAdd, string startChoicePlayers)
    {
        // Arrange
        var selector = new Selector(new GameLogger());
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(number);
        stringBuilder.AppendLine(isAdd);
        stringBuilder.AppendLine(startChoicePlayers);
        var stringReader = new StringReader(stringBuilder.ToString());
        Console.SetIn(stringReader);

        // Act
        bool result = false;
        List<bool> ListBool = selector.SelectCustomClass();

        foreach (var element in ListBool)
        {
            result = element;

            if (result == true)
            {
                break;
            }
        }

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("10")]
    [InlineData("11", "12")]
    [InlineData("12")]
    public void SelectNumbPlayersTest(string number, string secondNumber = "14")
    {
        // Arrange
        var selector = new Selector(new GameLogger());
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(number);

        if (!(Int32.Parse(number) % 2 == 0))
        {
            stringBuilder.AppendLine(secondNumber);
        }

        var stringReader = new StringReader(stringBuilder.ToString());
        Console.SetIn(stringReader);

        // Act
        var result = false;
        var player = selector.SelectNumbPlayers();
        if (player % 2 == 0)
        {
            result = true;
        }

        // Assert
        Assert.True(result);
    }
}