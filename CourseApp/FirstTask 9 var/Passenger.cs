namespace CourseApp;

public class Passenger : Airplane
{
    public Passenger(int speed, int flight, string model)
        : base(speed, flight, model)
    {
    }

    public override string MyRole()
    {
        return "Роль пассажирского самолета - перевозка пассажиров и багажа.";
    }

    public override string ToString()
    {
        return $"Passenger ( speed: {Speed}, flight: {Flight}, model: {Model})";
    }
}