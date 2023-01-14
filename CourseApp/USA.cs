namespace CourseApp;

using System;

public class USA : Country
{
    public USA(string name, string capital, double sq)
        : base(name, capital, sq)
    {
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