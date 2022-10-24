namespace CourseApp;

using System;

public class Canada : Country
{
    private int positionSq = 2;

    public Canada(string name, string capital, double sq)
        : base(name, capital, sq)
    {
    }

    public void PositionSquare()
    {
        Console.WriteLine($"{Name} in {positionSq} place in terms of area ");
    }

    public override string CountryAge()
    {
        return "155 years ";
    }

    public override string PresidentsName()
    {
        return "Carl ";
    }

    public override string NameOfElement()
    {
        return "Canada: ";
    }

    public override string ToString()
    {
        return $"{Capital} is a capital of {Name}";
    }
}