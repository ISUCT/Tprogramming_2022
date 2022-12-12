namespace CourseApp.GeneratePlayers
{
    using System;
    using System.Collections.Generic;
    using CourseApp.PlayerNames;
    using CourseApp.Players;

    public class PlayersGenerator
    {
        public PlayersGenerator(int playerCount, List<Names> names, List<bool> newClasses)
        {
            PlayersCount = playerCount;
            PlayerNames = names;
            NewClasses = newClasses;
        }

        private int PlayersCount { get; set; }

        private List<Names> PlayerNames { get; set; }

        private List<bool> NewClasses { get; set; }

        public List<IPlayer> GeneratePlayersArray()
        {
            var result = new List<IPlayer>();
            var rand = new Random();
            for (int i = 0; i < PlayersCount; i++)
            {
                IPlayer player;
                var playerName = PlayerNames[rand.Next(PlayerNames.Count)].PlayerName;
                var playerStrength = rand.Next(25, 51);
                var playerHealth = rand.Next(50, 101);
                var playerVariant = rand.Next(0, 3);
                switch (playerVariant)
                {
                    case 0:
                        if (NewClasses[1] == true)
                        {
                            if (rand.Next(0, 2) > 0)
                            {
                                player = new Knight(playerName, playerStrength, playerHealth, "Рыцарь");
                            }
                            else
                            {
                                player = new Knight(playerName, playerStrength, playerHealth, "Воин");
                            }
                        }
                        else
                        {
                            player = new Knight(playerName, playerStrength, playerHealth, "Рыцарь");
                        }

                        break;
                    case 1:
                        if (NewClasses[0] == true)
                        {
                            if (rand.Next(0, 2) > 0)
                            {
                                player = new Mage(playerName, playerStrength, playerHealth, "Маг");
                            }
                            else
                            {
                                player = new Mage(playerName, playerStrength, playerHealth, "Огненный маг");
                            }
                        }
                        else
                        {
                            player = new Mage(playerName, playerStrength, playerHealth, "Маг");
                        }

                        break;
                    case 2:
                        if (NewClasses[2] == true)
                        {
                            if (rand.Next(0, 2) > 0)
                            {
                                player = new Archer(playerName, playerStrength, playerHealth, "Лучник");
                            }
                            else
                            {
                                player = new Archer(playerName, playerStrength, playerHealth, "Стрелок");
                            }
                        }
                        else
                        {
                            player = new Archer(playerName, playerStrength, playerHealth, "Лучник");
                        }

                        break;
                    default:
                        throw new Exception();
                }

                result.Add(player);
            }

            return result;
        }
    }
}
