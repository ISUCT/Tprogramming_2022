﻿namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Game
    {
        public static void Start()
        {
            int p_number = AskNumber();
            List<Player> playerList = PlayerListGenerator(p_number);
            RandomizeList(ref playerList);
            PlayGame(ref playerList);
        }

        private static void PlayGame(ref List<Player> playerList)
        {
            for (int i = 1; playerList.Count != 1; i++)
            {
                Logger.WriteRound(i);
                PlayRound(ref playerList);
            }

            Logger.WriteWinner(playerList[0]);
        }

        private static void PlayRound(ref List<Player> playerList)
        {
            for (int i = 0; i < playerList.Count / 2; i++)
            {
                Player[] fightMembers = { playerList[i * 2], playerList[(i * 2) + 1] };
                Logger.WriteFight(fightMembers);
                playerList[i * 2] = PlayFight(fightMembers);
            }

            for (int i = 1; i < playerList.Count; i++)
            {
                playerList.RemoveAt(i);
            }
        }

        private static Player PlayFight(Player[] fightMembers)
        {
            for (int i = 0; true; i++)
            {
                var playerStatus = fightMembers[i % 2].CheckStatus();
                Logger.WriteAction(fightMembers[i % 2], playerStatus);
                bool checkDeath = fightMembers[i % 2].CheckDeath();
                if (checkDeath)
                {
                    fightMembers[(i + 1) % 2].Update();
                    return fightMembers[(i + 1) % 2];
                }

                if (playerStatus.Contains(Tuple.Create("Удар щитом", .0f)))
                {
                    continue;
                }

                Tuple<string, float> playerAction = PlayerDoAction(fightMembers[i % 2]);
                Logger.WriteAction(fightMembers[i % 2], fightMembers[(i + 1) % 2], playerAction);
                if (playerAction.Item1 != "наносит урон")
                {
                    fightMembers[(i + 1) % 2].SetDebaff(playerAction.Item1);
                }

                checkDeath = fightMembers[(i + 1) % 2].GetDamage(playerAction.Item2);
                Logger.WriteDeath(fightMembers[(i + 1) % 2], checkDeath);
                if (checkDeath)
                {
                    fightMembers[i % 2].Update();
                    return fightMembers[i % 2];
                }
            }
        }

        private static Tuple<string, float> PlayerDoAction(Player inputP)
        {
            Random rnd = new Random();
            int chosen = rnd.Next(0, 4);
            switch (chosen)
            {
                case 0:
                    return inputP.Ability();
                default:
                    return inputP.Attack();
            }
        }

        private static int AskNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите четное количество игроков:");
                int p_number = Convert.ToInt32(Console.ReadLine());
                if (p_number <= 0)
                {
                    Console.WriteLine("Число игроков должно быть больше 0!");
                }
                else if (p_number % 2 != 0)
                {
                    Console.WriteLine("Число игроков должно быть четным!");
                }
                else
                {
                    return p_number;
                }
            }
        }

        private static void RandomizeList(ref List<Player> input)
        {
            Random rnd = new Random();
            var buffer = input.ToArray();
            for (int i = 0; i < input.Count; i++)
            {
                int chosen = rnd.Next(i, buffer.Length);
                (buffer[i], buffer[chosen]) = (buffer[chosen], buffer[i]);
            }

            input = buffer.ToList();
        }

        private static List<Player> PlayerListGenerator(int count)
        {
            List<Player> playerList = new List<Player>();
            for (int i = 0; i < count; i++)
            {
                playerList.Add(PlayerGenerator());
            }

            return playerList;
        }

        private static Player PlayerGenerator()
        {
            string[] names = { "Торек Айронбрау", "Гром Брюхо", "Локхир Падшее Сердце", "Алариэль Лучезарная", "Имрик", "Зигмар", "Третч Крейвентейл", "Архан Черный", "Аранесса Солтспайт", "Великий Иерофант Хатеп", "Задушите Нечистого", "Лорд Скролк", "Лорд Маздамунди" };
            Random rnd = new Random();
            int health = (int)rnd.NextInt64(81, 101);
            int strength = (int)rnd.NextInt64(11, 26);
            int chouse = (int)rnd.NextInt64(0, 3);
            switch (chouse)
            {
                case 0:
                    return new Barbarian(health, strength, names[rnd.Next(names.Length)]);
                case 1:
                    return new Shielder(health, strength, names[rnd.Next(names.Length)]);
                case 2:
                    return new Assassin(health, strength, names[rnd.Next(names.Length)]);
                default:
                    return new Barbarian(health, strength, names[rnd.Next(names.Length)]);
            }
        }
    }
}
