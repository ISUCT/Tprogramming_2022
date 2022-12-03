namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public static class Logger
    {
        public static void WriteWinner(Player winner)
        {
            Console.WriteLine($"{winner.ToString()} ПОБЕДИЛ!");
        }

        public static void WriteRound(int round)
        {
            Console.WriteLine($"Раунд {round}.");
        }

        public static void WriteFight(Player[] fightMembers)
        {
            Console.WriteLine($"{fightMembers[0].ToString()} VS {fightMembers[1].ToString()}");
        }

        public static void WriteAction(Player firstP, Player secondP, Tuple<string, float> playerAction)
        {
            switch (playerAction.Item1)
            {
                case "наносит урон":
                    Console.WriteLine($"{firstP.ToString()} наносит урон {playerAction.Item2} противнику {secondP.ToString()}");
                    break;
                case "Удар возмездия":
                    Console.WriteLine($"{firstP.ToString()} применяет ({playerAction.Item1}) и наносит урон {playerAction.Item2} противнику {secondP.ToString()}");
                    break;
                case "Огненная стрела":
                    Console.WriteLine($"{firstP.ToString()} применяет ({playerAction.Item1}) по противнику {secondP.ToString()}");
                    break;
                case "Заворожение":
                    Console.WriteLine($"{firstP.ToString()} применяет ({playerAction.Item1}) по противнику {secondP.ToString()}");
                    break;
            }
        }

        public static void WriteAction(Player inputP, List<Tuple<string, float>> playerStatus)
        {
            foreach (var debaff in playerStatus)
            {
                switch (debaff.Item1)
                {
                    case "Огненная стрела":
                        Console.WriteLine($"{inputP.ToString()} получает периодический урон {debaff.Item2} от ({debaff.Item1})");
                        break;
                    case "Заворожение":
                        Console.WriteLine($"{inputP.ToString()} пропускает ход из-за ({debaff.Item1})");
                        break;
                    case "PlayerIsDied":
                        Console.WriteLine($"{inputP.ToString()} погибает");
                        Console.WriteLine();
                        break;
                }
            }
        }

        public static void WriteDeath(Player inputP, bool isDeath)
        {
            if (isDeath)
            {
                Console.WriteLine($"{inputP.ToString()} погибает");
                Console.WriteLine();
            }
        }
    }
}