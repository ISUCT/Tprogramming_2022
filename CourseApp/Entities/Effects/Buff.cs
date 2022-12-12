namespace CourseApp.Effects
{
    using System.Linq;
    using CourseApp.Players;

    public class Buff : IEffect
    {
        public Buff(double factor, int round)
        {
            Factor = factor;
            LastUsedRound = round;
        }

        public double Factor { get; set; }

        public int LastUsedRound { get; set; }

        public void State(IPlayer player)
        {
            player.Strength = (int)((double)player.Strength * Factor);
        }

        public void DeleteState(IPlayer player, int round, int numberPlayer)
        {
            if (round - LastUsedRound == 1)
            {
                if (player.NormalState is Normal normal)
                {
                    normal.RestoreStrength(player);
                }

                foreach (var effect in player.MyEffects.ToList())
                {
                    if (effect is Buff buff)
                    {
                        player.MyEffects.Remove(buff);
                    }
                }
            }
        }
    }
}
