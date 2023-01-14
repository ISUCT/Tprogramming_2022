namespace CourseApp
{
    using System;

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

        public static void WriteFight(Player[] opponents)
        {
            Console.WriteLine($"{opponents[0].ToString()} VS {opponents[1].ToString()}");
        }

        // у метода следующие перегрузки: применение способности по противнику, применение атакующей способности, действующие на игрока дебафы
        public static void WriteAction(Player firstP, Player secondP, string action)
        {
            Console.WriteLine($"{firstP.ToString()} применяет ({action}) по противнику {secondP.ToString()}");
        }

        public static void WriteAction(Player firstP, Player secondP, string action, float damage)
        {
            switch (action)
            {
                case "Атака":
                    Console.WriteLine($"{firstP.ToString()} наносит урон {damage} противнику {secondP.ToString()}");
                    break;
                case "Удар возмездия":
                    Console.WriteLine($"{firstP.ToString()} применяет ({action}) и наносит урон {damage} противнику {secondP.ToString()}");
                    break;
            }
        }

        public static void WriteAction(Player inputP, string action)
        {
            switch (action)
            {
                case "Огненная стрела":
                    Console.WriteLine($"{inputP.ToString()} получает периодический урон {2} от ({action})");
                    break;
                case "Заворожение":
                    Console.WriteLine($"{inputP.ToString()} пропускает ход из-за ({action})");
                    break;
            }
        }

        public static void WriteDeath(Player inputP)
        {
            Console.WriteLine($"{inputP.ToString()} погибает");
            Console.WriteLine();
        }
    }
}
