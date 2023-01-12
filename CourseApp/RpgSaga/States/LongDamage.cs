using System.Linq;
using CourseApp.RpgSaga.Players;

namespace CourseApp.RpgSaga.States;

public class LongDamage : IState
{
    public LongDamage(int factor, int round)
    {
        Factor = factor;
        LastUsed = round;
    }

    public int Factor { get; set; }

    public int LastUsed { get; set; }

    public void State(Player enemy)
    {
        enemy.Health -= Factor;
    }

    public void DeleteState(Player player, int round, int numberPlayer)
    {
        if ((round - LastUsed == 10 && numberPlayer == 2) || (round - LastUsed == 11 && numberPlayer == 1))
        {
            foreach (var state in player.MyStates.ToList())
            {
                if (state is LongDamage longDamage)
                {
                    player.MyStates.Remove(longDamage);
                }
            }
        }
    }
}
