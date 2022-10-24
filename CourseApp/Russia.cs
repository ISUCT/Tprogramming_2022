namespace CourseApp;

using System;

public class Russia : Country
{
    private int positionSq = 1;

    public Russia(string name, string capital, double sq)
        : base(name, capital, sq)
    {
    }

    public void PositionSquare()
    {
        Console.WriteLine($"{Name} in {positionSq} place in terms of area ");
    }

    public override string CountryAge()
    {
        return "1159 years ";
    }

    public override string PresidentsName()
    {
        return "Putin ";
    }

    public override string NameOfElement()
    {
        return "Russia: ";
    }

    public override string ToString()
    {
        return $"{Capital} is a capital of {Name}";
    }
}