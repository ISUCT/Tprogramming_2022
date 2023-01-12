namespace CourseApp.RpgSaga.Players;

using CourseApp.RpgSaga.Powers;

public class Knight : Player
{
    public Knight(string name, int strength, int health)
        : base(name, strength, health)
    {
        ClassName = "Рыцарь";
        Power = new VengeanceStrike();
    }
}