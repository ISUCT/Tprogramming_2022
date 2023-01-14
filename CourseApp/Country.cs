namespace CourseApp;

using System;

public abstract class Country
{
    private double square;

    public Country(string name, string capital, double sq)
    {
        this.Name = name;
        this.Capital = capital;
        this.Square = sq;
    }

    public string Name { get; set; }

    public string Capital { get; set; }

    public double Square
    {
        get
        {
            return square;
        }

        set
        {
            square = value;
        }
    }

    public void Print()
    {
        Console.Write($"Название: {Name}  Столица: {Capital}  Площадь: {Square} км^2 ");
    }

    public virtual string CountryAge()
    {
        return "2000 years";
    }

    public virtual string PresidentsName()
    {
        return "sss";
    }

    public virtual string NameOfElement()
    {
        return "3";
    }
}