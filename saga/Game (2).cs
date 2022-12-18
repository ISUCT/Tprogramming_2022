namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Game
    {
        public static void Play()
        {
            int num = AskNum();
            List<Player> playerList = PlayersList(num);
            RNDList(ref playerList);
            PlayGame(ref playerList);
        }

        private static void PlayGame(ref List<Player> playerList)
        {
            for (int i = 1; playerList.Count != 1; i++)
            {
                Logger.Write(i);
                PlayRound(ref playerList);
            }

            Logger.Write(playerList[0]);
        }

        private static void PlayRound(ref List<Player> playerList)
        {
            for (int i = 0; i < playerList.Count / 2; i++)
            {
                Logger.Write(playerList[i * 2], playerList[(i * 2) + 1]);
                playerList[i * 2] = Fight(playerList[i * 2], playerList[(i * 2) + 1]);
            }

            for (int i = 1; i < playerList.Count; i++)
            {
                playerList.RemoveAt(i);
            }
        }

        private static Player Fight(Player first, Player second)
        {
            for (int i = 0; true; i++)
            {
                if (i != 0)
                {
                    (first, second) = (second, first);
                }

                string debaffinf = first.DebaffInfo();
                Logger.Write(first, debaffinf);
                bool checkDeath = first.IsDeath();
                if (checkDeath)
                {
                    Logger.Write(first, true);
                    second.Update();
                    return second;
                }

                if (debaffinf == "Заколдованная пыль")
                {
                    continue;
                }

                string action = PlayerAct();
                if (action == "ab")
                {
                    var actionisdone = first.Ability();
                    if (actionisdone != "нанесла урон")
                    {
                        if (actionisdone == "Розовый удар")
                        {
                            Logger.Write(first, second, actionisdone, (float)Math.Round(first.Attack() * 1.3f, 2));
                            second.Damage((float)Math.Round(first.Attack() * 1.3f, 2));
                        }
                        else
                        {
                            Logger.Write(first, second, actionisdone);
                            second.Debaff(actionisdone);
                        }
                    }
                    else
                    {
                        Logger.Write(first, second, actionisdone, first.Attack());
                        second.Damage(first.Attack());
                    }
                }
                else
                {
                    Logger.Write(first, second, "нанесла урон", first.Attack());
                    second.Damage(first.Attack());
                }

                checkDeath = second.IsDeath();
                if (checkDeath)
                {
                    Logger.Write(second, true);
                    first.Update();
                    return first;
                }
            }
        }

        private static string PlayerAct()
        {
            Random rnd = new Random();
            int action = rnd.Next(0, 2);
            if (action == 0)
            {
                return "ab";
            }
            else
            {
                return "at";
            }
        }

        private static int AskNum()
        {
            while (true)
            {
                Console.WriteLine("Введите четное количество игроков:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("КАКОЕ НОЛЬ, КАК ИХ МЕНЬШЕ 2 МОЖЕТ БЫТЬ!");
                }
                else if (number % 2 != 0)
                {
                    Console.WriteLine("ЧЕТНОЕ ДАЙ МНЕ!");
                }
                else
                {
                    return number;
                }
            }
        }

        private static void RNDList(ref List<Player> input)
        {
            Random rnd = new Random();
            Player[] buffer = input.ToArray();
            for (int i = 0; i < input.Count; i++)
            {
                int pos = rnd.Next(i, buffer.Length);
                (buffer[i], buffer[pos]) = (buffer[pos], buffer[i]);
            }

            input = buffer.ToList();
        }

        private static List<Player> PlayersList(int count)
        {
            List<Player> players = new List<Player>();
            for (int i = 0; i < count; i++)
            {
                players.Add(PGen());
            }

            return players;
        }

        private static Player PGen()
        {
            Random rnd = new Random();
            string[] name = { "Колмезер", "Мэлдебель", "Сьюбексика", "Вилоура", "Бонреетта", "Эрсэн", "Челриция", "Антлейси", "Кейоан", "Хоуелоун", "Дамсзен", "Анжиия", "Глозетда" };
            int health = rnd.Next(1, 50);
            int strength = rnd.Next(1, 20);
            int classChouse = rnd.Next(0, 3);
            if (classChouse == 0)
            {
                return new Warrior(health, strength, name[rnd.Next(name.Length)]);
            }
            else if (classChouse == 1)
            {
                return new Mage(health, strength, name[rnd.Next(name.Length)]);
            }
            else
            {
                return new Archer(health, strength, name[rnd.Next(name.Length)]);
            }
        }
    }
}