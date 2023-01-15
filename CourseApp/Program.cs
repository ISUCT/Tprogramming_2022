namespace CourseApp
{
    using System;

    public class Program
    {
        private static ILogger logger;

        public static void Main(string[] args)
        {
            logger = new Logger();
            int playersCount;
            logger.Log("Введите число игроков:");
            int.TryParse(Console.ReadLine(), out playersCount);
            if (playersCount % 2 != 0)
            {
                logger.Log("Число игроков должно быть четным");
                return;
            }

            BattleManager bm = new BattleManager(playersCount, logger);
            bm.Battle();
        }
    }
}
