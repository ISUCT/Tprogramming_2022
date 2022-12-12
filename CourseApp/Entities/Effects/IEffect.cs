namespace CourseApp.Effects
{
    using CourseApp.Players;

    public interface IEffect
    {
        int LastUsedRound { get; set; }

        void State(IPlayer player);

        void DeleteState(IPlayer player, int round, int numberPlayer);
    }
}
