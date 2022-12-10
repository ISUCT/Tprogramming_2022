namespace CourseApp.Tests;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using CourseApp.Base;
using CourseApp.GeneratePlayers;
using CourseApp.Logger;
using CourseApp.Players;
using CourseApp.SelectorGame;
using PlayerNames;
using Xunit;

[Collection("Sequential")]
public class GameTest
{
    [Fact]
    public void DraftTest()
    {
        // Arrange
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("1");
        stringBuilder.AppendLine("Да");
        stringBuilder.AppendLine("Да");
        stringBuilder.AppendLine("10");
        var stringReader = new StringReader(stringBuilder.ToString());
        Console.SetIn(stringReader);


        Game game = new Game(new GameLogger());
        Selector selector = new Selector(new GameLogger());
        List<bool> newClasses = selector.SelectCustomClass();
        int playerNumbers = selector.SelectNumbPlayers();

        const string filepath = @"/home/kiosk/Develop/Tprogramming_2022/CourseApp/Main/Names.json";
        var json = File.ReadAllText(filepath);
        var playerNames = JsonSerializer.Deserialize<List<Names>>(json);

        PlayersGenerator playersGenerator = new PlayersGenerator(playerNumbers, playerNames, newClasses);

        List<IPlayer> players = new List<IPlayer>(playersGenerator.GeneratePlayersArray());

        // Act
        var playersCopy = new List<IPlayer>(players);
        game.Draft(players);

        // Assert
        Assert.NotSame(players, playersCopy);
    }

    [Fact]
    public void TourTest()
    {
        // Arrange
        Game game = new Game(new GameLogger());
        List <IPlayer> players= new List<IPlayer>();
        players.Add(new Archer("Max", 10, 30, "Рыцарь"));
        players.Add(new Archer("Max", 10, 30, "Рыцарь"));
        players.Add(new Archer("Max", 10, 30, "Рыцарь"));

        // Act
        game.Tour(players);

        // Assert
        Assert.NotEmpty(players);
    }

    [Fact]
    public void EndGameTest()
    {
        // Arrange
        Game game = new Game(new GameLogger());
        List <IPlayer> players= new List<IPlayer>();
        players.Add(new Archer("Max", 40, 30, "Рыцарь"));

        // Act
        var result = game.EndGame(players);

        // Assert
        Assert.True(result);
    }
}