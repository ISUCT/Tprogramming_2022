namespace CourseApp;
using System;

public abstract class Country
{
    private IHymnBehavior hymnBehavior;
    private int gdp;
    private int population;
    private string countryName;

    public int Gdp
    {
        get => gdp;
        set
        {
            if (value > 1 && value <= 5000)
            {
                gdp = value;
            }
            else
            {
                Console.WriteLine("GDP not suitable");
            }
        }
   }

    public int Population
    {
        get => population;
        set
        {
            if (value > 800)
            {
                population = value;
            }
            else
            {
                Console.WriteLine("Population not suitable");
            }
        }
    }

    public IHymnBehavior HymnBehavior
    {
        get => hymnBehavior;
        set => hymnBehavior = value;
    }

    public string CountryName
    {
        get => countryName;
        set => countryName = value;
    }

    public void SetHymnBehavior(IHymnBehavior hb)
    {
        hymnBehavior = hb;
    }

    public void PerformHymn()
    {
        hymnBehavior.Hymn();
    }

    public void PrintCountryName()
    {
        Console.WriteLine("Country name is " + CountryName);
    }
}
