namespace CourseApp.Effects
{
    using CourseApp.Players;

    public class Normal : IEffect
    {
        public Normal(int strength, int health)
        {
            Health = health;
            Strength = strength;
        }

        public int Health { get; set; }

        public int Strength { get; set; }

        public int LastUsedRound { get; set; }

        public void State(IPlayer myself)
        {
            myself.Strength = Strength;
            myself.Health = Health;
        }

        public void RestoreStrength(IPlayer myself)
        {
            myself.Strength = Strength;
        }

        public void RestoreHealth(IPlayer myself)
        {
            myself.Health = Health;
        }

        public void DeleteState(IPlayer player, int round, int numberPlayer)
        {
            player.MyEffects = null;
        }
    }
}
