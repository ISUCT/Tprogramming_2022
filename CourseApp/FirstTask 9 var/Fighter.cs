namespace CourseApp;

public class Fighter : Airplane
{
    public Fighter(int speed, int flight, string model)
        : base(speed, flight, model)
    {
    }

    public override string MyRole()
    {
        return "Роль военного самолета - уничтожение противника.";
    }

    public override string ToString()
    {
        return $"Fighter ( speed: {Speed}, flight: {Flight}, model: {Model})";
    }
}