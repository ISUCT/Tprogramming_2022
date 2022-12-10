namespace CourseApp
{
    namespace Effects
    {
        using System.Linq;
        using Players;
        public class Stun : IEffect
        {
            public int LastUsedRound { get; set; }

            public Stun(int round)
            {
                LastUsedRound = round;
            }

            public void State(IPlayer Player)
            {
                Player.Strength = 0;
            }

            public void DeleteState(IPlayer Player, int Round, int numberPlayer)
            {
                foreach (var effect in Player.MyEffects.ToList())
                {
                    if (effect is Stun stun)
                    {
                        if ((Round - effect.LastUsedRound == 1 && numberPlayer == 2) || (Round - effect.LastUsedRound == 2 && numberPlayer == 1))
                        {
                            Player.MyEffects.Remove(stun);
                            if (Player.NormalState is Normal normal) normal.RestoreStrength(Player);
                        }
                    }
                }
            }
        }
    }
}
