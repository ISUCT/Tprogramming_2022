namespace CourseApp;
using System;

public abstract class Airplane
{
    private int speed;
    private int flight;
    private string model;

    public Airplane(int speed, int flight, string model)
    {
        Speed = speed;
        Flight = flight;
        Model = model;
    }

    public Airplane()
    {
        Speed = 800;
        Flight = 666;
        Model = "A320";
    }

    public int Speed
    {
        get => speed;
        set
        {
            if ((value >= 260) || (value < 850 && value > 800) || (value > 200 && value < 250))
            {
                speed = value;
            }
            else
            {
                throw new Exception("Слишком маленькая скорость");
            }
        }
    }

    public string Model
    {
        get => model;
        set => model = value;
    }

    public int Flight
    {
        get => flight;
        set
        {
            if (value > 0 && value < 1001)
            {
                flight = value;
            }
            else
            {
                throw new Exception("Недопустимый номер рейса");
            }
        }
    }

    public string GetTakeOff()
    {
        if (speed >= 260)
        {
            return "Cамолет взлетел";
        }
        else
        {
            return "Слишком маленькая скорость для взлета";
        }
    }

    public string GetFly()
    {
        if (speed < 850 && speed > 800)
        {
            return "Самолет летит";
        }
        else
        {
            return "Наберите нужную скорость";
        }
    }

    public string GetLanding()
    {
        if (speed > 200 && speed < 250)
        {
            return "Самолет приземлился";
        }
        else
        {
            return "Повысьте или понизьте скорость";
        }
    }

    public void TakeOff()
    {
        Console.WriteLine(GetTakeOff());
    }

    public void Fly()
    {
        Console.WriteLine(GetFly());
    }

    public void Landing()
    {
        Console.WriteLine(GetLanding());
    }

    public abstract string MyRole();
}