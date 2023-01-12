namespace CourseApp.RpgSaga.Powers;

using CourseApp.RpgSaga.Players;

public interface IPower
{
    int UsedCount { get; set; }

    string Name { get; set; }

    void Spell(Player myself, Player enemy, int round);

    bool CanSpell();
}