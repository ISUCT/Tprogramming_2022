namespace CourseApp
{
    namespace Effects
    {
        using System.Linq;
        using Players;
        public class Buff : IEffect
        {
            public double Factor { get; set; }

            public int LastUsedRound { get; set; }

            public Buff(double factor, int round)
            {
                Factor = factor;
                LastUsedRound = round;
            }

            public void State(IPlayer Player)
            {
                Player.Strength = (int)((double)Player.Strength * Factor);
            }

            public void DeleteState(IPlayer Player, int Round, int numberPlayer)
            {
                if (Round - LastUsedRound == 1)
                {
                    if (Player.NormalState is Normal normal) normal.RestoreStrength(Player);
                    foreach (var effect in Player.MyEffects.ToList())
                    {
                        if (effect is Buff buff)
                        {
                            Player.MyEffects.Remove(buff);
                        }
                    }
                }
            }
        }   
    }
}
