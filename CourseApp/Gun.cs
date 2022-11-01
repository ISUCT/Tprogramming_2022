using System;

namespace CourseApp;

public class Gun
{
    public Gun(string model , decimal kalibr , string years )
    {
        Model = model;
        Kalibr = kalibr;
        Years = years;
    }

    public Gun()
    {
        throw new NotImplementedException();
    }

    public string Model
    {
        get;
        set;
    }

    public decimal Kalibr
    {
        get;
        set;
    }

    public string Years
    {
        get;
        set;
    }

    public void Display()
    {
        Console.WriteLine($"We have gun:{Model} kalibr:{Kalibr} years:{Years}");
    }
}