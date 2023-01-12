namespace CourseApp.RpgSaga.Powers;

using CourseApp.RpgSaga.States;
using CourseApp.RpgSaga.Players;

public class Freeze : IPower
{
    public int UsedCount { get; set; } = 0;

    public string Name { get; set; } = "Заворожение";

    public void Spell(Player myself, Player enemy, int round)
    {
        enemy.MyStates.Add(new Stun(round));
        UsedCount++;
    }

    public bool CanSpell()
    {
        return true;
    }
}