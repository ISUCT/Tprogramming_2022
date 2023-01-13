namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public static class Logger
    {
        public static void Write(Player winner)
        {
            Console.WriteLine($"{winner.ToString()} ПОБЕДИЛА!");
        }

        public static void Write(int round)
        {
            Console.WriteLine($"Раунд {round}");
        }

        public static void Write(Player first, Player second)
        {
            Console.WriteLine($"{first.ToString()} VS {second.ToString()}");
        }

        public static void Write(Player first, Player second, string action)
        {
            Console.WriteLine($"{first.ToString()} применила ({action}) по противнику {second.ToString()}");
        }

        public static void Write(Player first, Player second, string action, float damage)
        {
            if (action != "нанесла урон")
            {
                Console.WriteLine($"{first.ToString()} применила ({action}) и нанесла урон {damage} противнику {second.ToString()}");
            }
            else
            {
                Console.WriteLine($"{first.ToString()} нанесла урон {damage} противнику {second.ToString()}");
            }
        }

        public static void Write(Player inputP, string debaff)
        {
                switch (debaff)
                {
                case "Cтрелы любви":
                    Console.WriteLine($"{inputP.ToString()} получила периодический урон 2 от ({debaff})");
                    break;
                case "Заколдованная пыль":
                    Console.WriteLine($"{inputP.ToString()} пропустила ход из-за ({debaff})");
                    break;
            }
        }

        public static void Write(Player inputP, bool isDeath)
        {
            if (isDeath)
            {
                Console.WriteLine($"{inputP.ToString()} погибла :)");
                Console.WriteLine();
            }
        }
    }
}