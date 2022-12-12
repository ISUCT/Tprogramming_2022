namespace CourseApp.Effects
{
    using System.Linq;
    using CourseApp.Players;

    public class Stun : IEffect
    {
        public Stun(int round)
        {
            LastUsedRound = round;
        }

        public int LastUsedRound { get; set; }

        public void State(IPlayer player)
        {
            player.Strength = 0;
        }

        public void DeleteState(IPlayer player, int round, int numberPlayer)
        {
            foreach (var effect in player.MyEffects.ToList())
            {
                if (effect is Stun stun)
                {
                    if ((round - effect.LastUsedRound == 1 && numberPlayer == 2) || (round - effect.LastUsedRound == 2 && numberPlayer == 1))
                    {
                        player.MyEffects.Remove(stun);
                        if (player.NormalState is Normal normal)
                        {
                            normal.RestoreStrength(player);
                        }
                    }
                }
            }
        }
    }
}
