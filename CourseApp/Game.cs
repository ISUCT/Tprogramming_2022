namespace CourseApp.RPGSaga
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga;

    public class Game
    {
        private static string[] _names = new string[20] { "Евгений", "Евграф", "Евдоким", "Евсей", "Евстафий", "Авдей", "Авксентий", "Агапит", "Агафон", "Акакий", "Ждан", "Зиновий", "Иакинф", "Иван", "Игнатий", "Вавила", "Вадим", "Валентин", "Валерий", "Валерьян" };
        private static Random _random = new Random();
        private static bool death;

        public static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            List<Player> battle = new List<Player>();
            int battleCounter = 0;
            int roundCounter = 0;

            Console.Write("Введите кол-во героев: ");
            int numberOfPlayers = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            if (numberOfPlayers % 2.0 != 0)
            {
                Console.WriteLine("Количество героев нечетное!");
                return;
            }

            for (int i = 0; i < numberOfPlayers; i++)
            {
                var randomName = _names[_random.Next(0, 20)];
                switch (CreatePlayers.GetHeroType())
                {
                    case PlayerTypes.NotType:
                        new Exception("Player has not type");
                        break;
                    case PlayerTypes.Knight:
                        players.Add(new Knight(randomName));
                        break;
                    case PlayerTypes.Archer:
                        players.Add(new Archer(randomName));
                        break;
                    case PlayerTypes.Wizard:
                        players.Add(new Wizard(randomName));
                        break;
                }
            }

            while (players.Count > 1)
            {
                battle.Add(players[_random.Next(0, players.Count)]);
                players.Remove(battle[0]);
                battle.Add(players[_random.Next(0, players.Count)]);
                players.Remove(battle[1]);

                Logger.Space();

                if (battleCounter % 2 == 0)
                {
                    Logger.WriteLog($"Кон {roundCounter += 1}");
                }

                Logger.Space();
                Logger.WriteLog(battle[0].ToString() + " vs " + battle[1].ToString());

                while (death == false)
                {
                    if (_random.Next(0, 5) == 2)
                    {
                        battle[0].Ultimate();
                        Logger.WriteLog(battle[0].ToString() + " ультует!");
                    }
                    else
                    {
                        battle[1].GetDamage(battle[0].GiveDamage());
                        Logger.WriteLog(battle[0].ToString() + $" наносит {battle[0].GiveDamage()} урона противнику: " + battle[1].ToString());
                    }

                    if (battle[1].Health < 1)
                    {
                        death = true;
                        players.Add(battle[0]);
                        Logger.WriteLog(battle[1].ToString() + " погибает");
                        break;
                    }

                    if (_random.Next(0, 10) == 2)
                    {
                        battle[1].Ultimate();
                        Logger.WriteLog(battle[1].ToString() + " ультует!");
                    }
                    else
                    {
                        battle[0].GetDamage(battle[1].GiveDamage());
                        Logger.WriteLog(battle[1].ToString() + $" наносит {battle[1].GiveDamage()} урона противнику: " + battle[0].ToString());
                    }

                    if (battle[0].Health < 1)
                    {
                        death = true;
                        players.Add(battle[1]);
                        Logger.WriteLog(battle[0].ToString() + " погибает");
                        break;
                    }
                }

                death = false;
                battle.Clear();
                battleCounter++;
            }

            Logger.Space();
            Logger.WriteLog(players[0].ToString() + " побеждает! Здоровья погибшим)");
            Logger.Space();
            Logger.WriteLog(@"         ___              ___  ______   ___    ___
                               \  \    ____    /  / |_    _| |    \ |   |
                                \  \  /    \  /  /    |  |   |     \|   |
                                 \  \/  /\  \/  /    _|  |_  |   \      |
                                  \____/  \____/    |______| |___|\_____|

");
        }
    }
}
