namespace CourseApp;

using System;

public class USA : Country
{
    private int positionSq = 3;

    public USA(string name, string capital, double sq)
        : base(name, capital, sq)
    {
    }

    public void PositionSquare()
    {
        Console.WriteLine($"{Name} in {positionSq} place in terms of area ");
    }

    public override string CountryAge()
    {
        return "245 years ";
    }

    public override string PresidentsName()
    {
        return "Biden ";
    }

    public override string NameOfElement()
    {
        return "USA: ";
    }

    public override string ToString()
    {
        return $"{Capital} is a capital of {Name}";
    }
}