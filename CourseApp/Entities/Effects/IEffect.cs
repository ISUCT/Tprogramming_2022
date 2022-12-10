namespace CourseApp
{
    namespace Effects
    {
        using Players;
        public interface IEffect
        {
            int LastUsedRound { get; set; }
            void State(IPlayer Player);
            void DeleteState(IPlayer Player, int round, int numberPlayer);
        }
    }
}
