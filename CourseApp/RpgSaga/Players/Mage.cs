using CourseApp.RpgSaga.Powers;

namespace CourseApp.RpgSaga.Players;

public class Mage : Player
{
    public Mage(string name, int strength, int health)
        : base(name, strength, health)
    {   
        ClassName = "Маг";
        Power = new Freeze();
    }
}