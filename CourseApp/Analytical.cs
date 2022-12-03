namespace CourseApp;

using System;

public class Analytical : Document
{
    public Analytical(string name, string type, double size)
        : base(name, type, size)
    {
    }

    public override string DocumentSize()
    {
        return $"{Size} Мб ";
    }

    public override string Way()
    {
        return "C:/work/documents";
    }

    public override string NameOfEl()
    {
        return "AnalyticalDocument: ";
    }

    public override string ToString()
    {
        return $"{Name}; {Size} Мб; {Type}";
    }
}