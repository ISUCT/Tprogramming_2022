namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Arena
    {
        private readonly Random random = new Random();
        private Logger logger = new Logger();
        private List<Player> host = new List<Player>();
        private List<Player> winners = new List<Player>();
        private players list = new players();


        private int round = 1;
        private int battle = 1;

        private Fight fight = new Fight();

        public void Lap(int players)
        {
            host = list.AddAtList(players);

            Logger.LoggerOutput("Участники предстоящего турнира:");
            foreach (Player item in host)
            {
                Logger.LoggerOutput($"{item.Class_player} {item.Name}");
            }

            Logger.LoggerOutput("**********************************************************");
            Logger.LoggerOutput($"Тур {round++}-й");
            while (host.Count + winners.Count > 1)
            {
                if (host.Count >= 2)
                {
                    int randomFirst = random.Next(0, host.Count);
                    int randomSecond = random.Next(0, host.Count);
                    while (randomFirst == randomSecond)
                    {
                        randomSecond = random.Next(0, host.Count);
                    }

                    Player warrior = host[randomFirst];
                    Player warrior_rival = host[randomSecond];
                    Logger.LoggerOutput($"И {battle++}-й бой! {warrior.Class_player}  {warrior.Name} против {warrior_rival.Class_player}  {warrior_rival.Name} \n");
                    fight.Play(warrior, warrior_rival);
                    Console.WriteLine("\n");
                    if (warrior.Health <= 0)
                    {
                        Logger.LoggerOutput($"{warrior.Class_player} {warrior.Name} умер");
                        warrior_rival.ResetHealth();
                        host.Remove(warrior);
                        host.Remove(warrior_rival);
                        winners.Add(warrior_rival);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{warrior_rival.Class_player} {warrior_rival.Name} умер");
                        warrior.ResetHealth();
                        host.Remove(warrior);
                        host.Remove(warrior_rival);
                        winners.Add(warrior);
                    }
                }

                if ((winners.Count >= 2) && (host.Count == 0))
                {
                    int randomFirst = random.Next(0, winners.Count);
                    int randomSecond = random.Next(0, winners.Count);
                    while (randomFirst == randomSecond)
                    {
                        randomSecond = random.Next(0, winners.Count);
                    }

                    Logger.LoggerOutput("**********************************************************");
                    Logger.LoggerOutput($"Тур {round++}-й");
                    Player warrior = winners[randomFirst];
                    Player warrior_rival = winners[randomSecond];
                    Logger.LoggerOutput($"И {battle++}-й бой! {warrior.Class_player}  {warrior.Name} против {warrior_rival.Class_player}  {warrior_rival.Name} \n");
                    fight.Play(warrior, warrior_rival);
                    if (warrior.Health <= 0)
                    {
                        Logger.LoggerOutput($"{warrior.Class_player} {warrior.Name} умер");
                        warrior_rival.ResetHealth();
                        winners.Remove(warrior);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{warrior_rival.Class_player} {warrior_rival.Name} умер");
                        warrior.ResetHealth();
                        winners.Remove(warrior_rival);
                    }
                }
            }

            Logger.LoggerOutput("Игра окончена");
            Logger.LoggerOutput($"\nПобеду одержал - {winners[0].Class_player} {winners[0].Name}!!!!!!!!!");
        }
    }
}