using CourseApp.RpgSaga.States;
using CourseApp.RpgSaga.Players;

namespace CourseApp.RpgSaga.Powers;
public class VengeanceStrike : IPower
{
    public int UsedCount { get; set; } = 0;

    public string Name { get; set; } = "Удар возмездия";

    public void Spell(Player myself, Player enemy, int round)
    {
        IState generateBuff = new Buff(1.3, round);
        myself.MyStates.Add(generateBuff);
        int indexEffect = myself.MyStates.IndexOf(generateBuff);
        myself.MyStates[indexEffect].State(myself);
        enemy.Health -= myself.Strength;
        UsedCount++;
    }

    public bool CanSpell()
    {
        return true;
    }
}