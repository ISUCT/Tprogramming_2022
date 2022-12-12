namespace CourseApp.Effects
{
    using System.Linq;
    using CourseApp.Players;

    public class LongDamage : IEffect
    {
        public LongDamage(int factor, int round)
        {
            Factor = factor;
            LastUsedRound = round;
        }

        public int Factor { get; set; }

        public int LastUsedRound { get; set; }

        public void State(IPlayer enemy)
        {
            enemy.Health -= Factor;
        }

        public void DeleteState(IPlayer player, int round, int numberPlayer)
        {
            if ((round - LastUsedRound == 10 && numberPlayer == 2) || (round - LastUsedRound == 11 && numberPlayer == 1))
            {
                foreach (var effect in player.MyEffects.ToList())
                {
                    if (effect is LongDamage longDamage)
                    {
                        player.MyEffects.Remove(longDamage);
                    }
                }
            }
        }
    }
}
