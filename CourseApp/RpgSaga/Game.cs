namespace CourseApp.RpgSaga;

using System;
using System.Collections.Generic;
using CourseApp.RpgSaga.Players;

public class Game
{
    public Game(Logger logger)
    {
        Log = logger;
    }

    private Logger Log { get; set; }

    public void Run()
    {
        Log.PrintStart();

        int playerNumbers = GetNumbPlayers();

        List<string> playerNames = new List<string>() { "Nikita", "Danya", "James", "Elton", "Vladimir", "Tom", "Bob", "Sam", "Mike", "Denji" };

        PlayersGenerator playersGenerator = new PlayersGenerator(playerNumbers, playerNames);

        List<Player> players = new List<Player>(playersGenerator.CreatePlayersArray());

        int tourNumber = 1;

        while (true)
        {
            Log.PrintTour(tourNumber);
            tourNumber++;

            DraftPlayers(players);
            NewTour(players);

            if (EndGame(players))
            {
                break;
            }
        }
    }

    private int GetNumbPlayers()
    {
        int playersNumbers;

        while (true)
        {
            Log.PrintNumberPlayers();

            #nullable enable
            string? numberOfPlayers = Console.ReadLine();

            if (int.TryParse(numberOfPlayers, out int i) && (i % 2 == 0))
            {
                playersNumbers = i;
                break;
            }
            else
            {
                Log.PrintWrongNumber();
            }
        }

        return playersNumbers;
    }

    private void DraftPlayers(List<Player> players)
    {
        Random random = new Random();
        for (int i = players.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
            var temp = players[j];
            players[j] = players[i];
            players[i] = temp;
        }
    }

    private void NewTour(List<Player> players)
    {
        for (int i = 0; i < players.Count; i++)
        {
            if (i + 1 < players.Count)
            {
                Fight fight = new Fight(players[i], players[i + 1], ref players, Log);
                fight.Battle();
            }
        }
    }

    private bool EndGame(List<Player> players)
    {
        if (players.Count == 1)
        {
            Log.PrintEnd(players[0]);
            return true;
        }

        return false;
    }
}