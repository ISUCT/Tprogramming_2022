namespace CourseApp.RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CourseApp.RPGSaga;
    using CourseApp.RPGSaga.Generator;
    using CourseApp.RPGSaga.Heroes;

    public class BattlesBuilder
    {
        private TournamentListGenerator tournamentListGenerator;
        private Fight fight;
        private int size;
        private List<Player> tournamentList;

        public BattlesBuilder(int size)
        {
            Size = size;
            tournamentListGenerator = new TournamentListGenerator(Size);
            tournamentList = new List<Player>();
        }

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                if (value > 1 && value % 2 == 0)
                {
                    size = value;
                }
                else
                {
                    size = 2;
                }
            }
        }

        public void StartTournament()
        {
            System.Console.WriteLine("Начало Турнира!");
            tournamentList = tournamentListGenerator.GenerateTournamentList();
            int i = 0;
            while (tournamentList.Count != 1)
            {
                i++;
                Logger.WriteLog(" ");
                Logger.WriteLog($"Round: {i}");
                Logger.WriteLog(" ");
                Logger.WriteLog("Участники:");
                RunBattle(tournamentList);
            }

            foreach (var player in tournamentList)
            {
                Console.WriteLine(player);
            }
        }

        public List<Player> RunBattle(List<Player> players)
        {
            List<Player> playersList = new List<Player>(players);

            foreach (var player in playersList.ToList())
            {
                System.Console.WriteLine(player.ToString());
                player.SetDefaultValues();
            }

            if (playersList.Count > 1)
            {
                tournamentList.Clear();
                if (playersList.Count % 2 == 0)
                {
                    for (int i = 0; i < playersList.Count; i += 2)
                    {
                        Logger.WriteLog(" ");
                        Logger.WriteLog($"Бой между: {playersList[i]}, {playersList[i + 1]}");
                        fight = new Fight(playersList[i], playersList[i + 1]);
                        fight.SetOpponent();
                        tournamentList.Add(fight.StartFight());
                    }
                }
                else
                {
                    for (int i = 0; i < playersList.Count - 1; i += 2)
                    {
                        Logger.WriteLog(" ");
                        Logger.WriteLog($"Бой между: {playersList[i]}, {playersList[i + 1]}");
                        fight = new Fight(playersList[i], playersList[i + 1]);
                        fight.SetOpponent();
                        tournamentList.Add(fight.StartFight());
                    }

                    tournamentList.Add(playersList.Last());
                }
            }

            return tournamentList;
        }

        public void GetWinner()
        {
            Logger.WriteLog("=======================================");
            Logger.WriteLog($"Winner IS {tournamentList[0]}");
            Logger.WriteLog("=======================================");
        }
    }
}