namespace CourseApp.RpgSaga.States;

using System.Linq;
using CourseApp.RpgSaga.Players;

public class Buff : IState
{
    public Buff(double factor, int round)
    {
        Factor = factor;
        LastUsed = round;
    }

    public double Factor { get; set; }

    public int LastUsed { get; set; }

    public void State(Player player)
    {
        player.Strength = (int)((double)player.Strength * Factor);
    }

    public void DeleteState(Player player, int round, int numberPlayer)
    {
        if (round - LastUsed == 1)
        {
            if (player.NormalState is Normal normal)
            {
                normal.RestoreStrength(player);
            }

            foreach (var effect in player.MyStates.ToList())
            {
                if (effect is Buff buff)
                {
                    player.MyStates.Remove(buff);
                }
            }
        }
    }
}