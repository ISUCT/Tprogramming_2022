using System;
using System.Collections.Generic;
using CourseApp.RpgSaga.Players;

public class PlayersGenerator
{
    public PlayersGenerator(int playerCount, List<string> names)
    {
        PlayersCount = playerCount;
        PlayerNames = names;
    }

    private int PlayersCount { get; set; }

    private List<string> PlayerNames { get; set; }

    public List<Player> CreatePlayersArray()
    {
        var result = new List<Player>();
        var rand = new Random();
        for (int i = 0; i < PlayersCount; i++)
        {
            Player player;
            var playerName = PlayerNames[rand.Next(PlayerNames.Count)];
            var playerStrength = rand.Next(10, 30);
            var playerHealth = rand.Next(50, 150);
            var playerVariant = rand.Next(0, 3);
            switch (playerVariant)
            {
                case 0:
                        player = new Knight(playerName, playerStrength, playerHealth);
                    break;
                case 1:
                        player = new Mage(playerName, playerStrength, playerHealth);
                    break;
                case 2:
                        player = new Archer(playerName, playerStrength, playerHealth);
                    break;
                default:
                    throw new Exception();
            }

            result.Add(player);
        }

        return result;
    }
}