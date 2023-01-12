namespace CourseApp.RpgSaga.Players;

using CourseApp.RpgSaga.Powers;

public class Archer : Player
{
    public Archer(string name, int strength, int health)
        : base(name, strength, health)
    {
        ClassName = "Лучник";
        Power = new FireArrows();
    }
}