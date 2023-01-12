namespace CourseApp.RpgSaga.Players;

using CourseApp.RpgSaga.Powers;

public class Mage : Player
{
    public Mage(string name, int strength, int health)
        : base(name, strength, health)
    {
        ClassName = "Маг";
        Power = new Freeze();
    }
}