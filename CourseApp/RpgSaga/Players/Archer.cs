using CourseApp.RpgSaga.Powers;

namespace CourseApp.RpgSaga.Players;

public class Archer : Player
{
    public Archer(string name, int strength, int health)
        : base(name, strength, health)
    {   
        ClassName = "Лучник";
        Power = new FireArrows();
    }
}