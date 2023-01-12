using CourseApp.RpgSaga.Powers;

namespace CourseApp.RpgSaga.Players;

public class Knight : Player
{
    public Knight(string name, int strength, int health)
        : base(name, strength, health)
    {   
        ClassName = "Рыцарь";
        Power = new VengeanceStrike();
    }
}