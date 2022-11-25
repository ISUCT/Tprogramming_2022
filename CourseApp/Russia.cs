namespace CourseApp;

using System;

public class Russia : Country
{
    public Russia(string name, string capital, double sq)
        : base(name, capital, sq)
    {
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