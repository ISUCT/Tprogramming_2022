namespace CourseApp;
using System;

public class Airplane
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
                Console.WriteLine("Слишком маленькая скорость");
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
                Console.WriteLine("Недопустимый номер рейса");
            }
        }
    }

    public void TakeOff()
    {
        if (speed >= 260)
        {
            Console.WriteLine("Самолет взлетел");
        }
        else
        {
            Console.WriteLine("Слишком маленькая скорость для взлета");
        }
    }

    public void Fly()
    {
        if (speed < 850 && speed > 800)
        {
            Console.WriteLine("Самолет летит");
        }
        else
        {
            Console.WriteLine("Наберите нужную скорость");
        }
    }

    public void Landing()
    {
        if (speed > 200 && speed < 250)
        {
            Console.WriteLine("Самолет приземлился");
        }
        else
        {
            Console.WriteLine("Повысьте или понизьте скорость");
        }
    }
}
