namespace CourseApp
{
    using System;

    public class Game
    {
        public int StartTheTournament(int na)
        {
            Logger.LoggerOutput("Введите количество участников турнира: ");
            na = Convert.ToInt32(Console.ReadLine());
            while ((na % 2 != 0) && (na > 0))
            {
                Logger.LoggerOutput("Введите количество участников турнира, которое больше нуля и кратно двум: ");
                na = Convert.ToInt32(Console.ReadLine());
            }

            return na;
        }
    }
}
