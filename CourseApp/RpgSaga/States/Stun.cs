using System.Linq;
using CourseApp.RpgSaga.Players;

namespace CourseApp.RpgSaga.States;

public class Stun : IState
{
    public Stun(int round)
    {
        LastUsed = round;
    }

    public int LastUsed { get; set; }

    public void State(Player player)
    {
        player.Strength = 0;
    }

    public void DeleteState(Player player, int round, int numberPlayer)
    {
        foreach (var state in player.MyStates.ToList())
        {
            if (state is Stun stun)
            {
                if ((round - state.LastUsed == 1 && numberPlayer == 2) || (round - state.LastUsed == 2 && numberPlayer == 1))
                {
                    player.MyStates.Remove(stun);
                    if (player.NormalState is Normal normal)
                    {
                        normal.RestoreStrength(player);
                    }
                }
            }
        }
    }
}