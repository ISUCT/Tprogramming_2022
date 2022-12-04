namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public static class Logger
    {
        public static void WriteWinner(Player winner)
        {
            Console.WriteLine($"{winner.ToString()} Оказался сильнее всех и побеждает!");
        }

        public static void WriteRound(int round)
        {
            Console.WriteLine($"Раунд {round}.");
        }

        public static void WriteFight(Player[] fightMembers)
        {
            Console.WriteLine($"{fightMembers[0].ToString()} - характеристики (ХП:{fightMembers[0].MaxHealth} Сила:{fightMembers[0].Strength}) против {fightMembers[1].ToString()} - характеристики (ХП:{fightMembers[1].MaxHealth} Сила:{fightMembers[1].Strength})");
        }

        public static void WriteAction(Player firstP, Player secondP, Tuple<string, float> playerAction)
        {
            switch (playerAction.Item1)
            {
                case "наносит урон":
                    Console.WriteLine($"{firstP.ToString()} наносит {playerAction.Item2} урона противнику ({secondP.ToString()})");
                    break;
                case "Ярость":
                    Console.WriteLine($"{firstP.ToString()} применяет ({playerAction.Item1}) и наносит {playerAction.Item2} урона противнику ({secondP.ToString()}) теряя при этом здоровье");
                    break;
                case "Кровавый удар":
                    Console.WriteLine($"{firstP.ToString()} применяет ({playerAction.Item1}) на противника ({secondP.ToString()})");
                    break;
                case "Удар щитом":
                    Console.WriteLine($"{firstP.ToString()} применяет ({playerAction.Item1}) на противника ({secondP.ToString()})");
                    break;
            }
        }

        public static void WriteAction(Player inputP, List<Tuple<string, float>> playerStatus)
        {
            foreach (var debaff in playerStatus)
            {
                switch (debaff.Item1)
                {
                    case "Кровавый удар":
                        Console.WriteLine($"{inputP.ToString()} получает периодический урон {debaff.Item2} от ({debaff.Item1})");
                        break;
                    case "Удар щитом":
                        Console.WriteLine($"{inputP.ToString()} пропускает ход из-за ({debaff.Item1})");
                        break;
                    case "PlayerIsDied":
                        Console.WriteLine($"{inputP.ToString()} не выдержал натиска");
                        Console.WriteLine();
                        break;
                }
            }
        }

        public static void WriteDeath(Player inputP, bool isDeath)
        {
            if (isDeath)
            {
                Console.WriteLine($"{inputP.ToString()} покидает этот бренный мир");
                Console.WriteLine();
            }
        }
    }
}
