namespace CourseApp.Logger
{
    using CourseApp.Players;

    public interface ILogger
    {
        void PrintStart();

        void PrintStartSelectHero();

        void PrintSelectHero();

        void PrintWrongNumber();

        void PrintAddAbility(int heroChoice);

        void PrintStartNumberPlayers();

        void PrintNumberPlayers();

        void PrintTour(int numberTour);

        void PrintEnd(IPlayer winner);

        void PrintVersus(IPlayer firstPlayer, IPlayer secondPlayer);

        void PrintAttack(IPlayer playerAttack, IPlayer playerDefend);

        void PrintUltimate(IPlayer playerAttack, IPlayer playerDefend, int randomUlt);

        void PrintEffect(IPlayer player);

        void PrintDefeat(IPlayer loser);
    }
}
