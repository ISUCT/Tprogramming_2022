namespace CourseApp.Base
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using CourseApp.Fight;
    using CourseApp.GeneratePlayers;
    using CourseApp.Logger;
    using CourseApp.PlayerNames;
    using CourseApp.Players;
    using CourseApp.SelectorGame;

    #nullable enable

    public class Game
    {
        public Game(ILogger gameLogger)
        {
            Logger = gameLogger;
            NumberTour = 1;

            const string filepath = @"/home/kiosk/Develop/Tprogramming_2022/CourseApp/Main/Names.json";

            var json = File.ReadAllText(filepath);
            PlayerNames = JsonSerializer.Deserialize<List<Names>>(json);
        }

        private ILogger Logger { get; set; }

        private int NumberTour { get; set; }

        private List<Names>? PlayerNames { get; set; }

        public void Run()
        {
            Logger.PrintStart();

            Selector selector = new Selector(Logger);

            List<bool> newClasses = selector.SelectCustomClass();

            int playerNumbers = selector.SelectNumbPlayers();

            PlayersGenerator playersGenerator = new PlayersGenerator(playerNumbers, PlayerNames, newClasses);

            List<IPlayer> players = new List<IPlayer>(playersGenerator.GeneratePlayersArray());

            while (true)
            {
                Logger.PrintTour(NumberTour);
                NumberTour++;

                Draft(players);
                Tour(players);

                if (EndGame(players))
                {
                    break;
                }
            }
        }

        public void Draft(List<IPlayer> players)
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

        public void Tour(List<IPlayer> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (i + 1 < players.Count)
                {
                    Fight fight = new Fight(players[i], players[i + 1], ref players, Logger);
                    fight.Battle();
                }
            }
        }

        public bool EndGame(List<IPlayer> players)
        {
            if (players.Count == 1)
            {
                Logger.PrintEnd(players[0]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
