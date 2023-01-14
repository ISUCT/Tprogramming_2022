namespace CourseApp.RPGSaga.Generator
{
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Heroes;
    using CourseApp.RPGSaga.Interfaces;

    public class TournamentListGenerator : ITournamentListGenerator
    {
        private int listSize;
        private CreatorPlayer creatorPlayer;
        private List<Player> tournamentList;

        public TournamentListGenerator(int listSize)
        {
            ListSize = listSize;
            creatorPlayer = new CreatorPlayer();
            tournamentList = new List<Player>();
        }

        public int ListSize
        {
            get
            {
                return listSize;
            }

            set
            {
                if (value > 1 && value % 2 == 0)
                {
                    listSize = value;
                }
                else
                {
                    listSize = 2;
                }
            }
        }

        public List<Player> GenerateTournamentList()
        {
            for (int i = 0; i < ListSize; i++)
            {
                tournamentList.Add(creatorPlayer.FactoryMethod());
            }

            return tournamentList;
        }
    }
}