namespace CourseApp.RpgSaga.Powers;

using CourseApp.RpgSaga.States;
using CourseApp.RpgSaga.Players;

public class FireArrows : IPower
{
    public string Name { get; set; } = "Огненные стрелы";

    public int UsedCount { get; set; } = 0;

    private int MaxUses { get; set; } = 1;

    public void Spell(Player myself, Player enemy, int round)
    {
        enemy.MyStates.Add(new LongDamage(5, round));
        UsedCount++;
    }

    public bool CanSpell()
    {
        if (UsedCount < MaxUses)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}