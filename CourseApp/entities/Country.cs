namespace CourseApp;
using System;

public class Country
{
    private IHymnBehavior hymnBehavior;
    private int gdp;
    private int population;
    private string countryName;

    public Country() : this("Vitalia") { }
    public Country(string countryName) : this(countryName, 3000) { }
    public Country(string countryName, int population) : this(countryName, population, 1000) { }
    public Country(string countryName, int population, int gdp) : this(countryName, population, gdp, new Literary())  { }
    public Country(string countryName, int population, int gdp, IHymnBehavior hymnBehavior) 
    {
        CountryName = countryName;
        Population = population;
        Gdp = gdp;

        HymnBehavior = hymnBehavior;
    }

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
                throw new Exception("GDP not suitable");
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
                throw new Exception("Population not suitable");
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


    public int PopulationCensus()
    {
        for (int person = 1; person <= Population; person++) 
        {
            if (person % 100 == 0) 
            {
                Console.WriteLine($"People counted - {person}");
            }
        }

        Console.WriteLine($"Population census carried out in {CountryName}");
        return Population;
    }


    public string PerformHymn()
    {
        hymnBehavior.Hymn();
        return hymnBehavior.HymnType;
    }

    public string PrintCountryInformation()
    {
        string countryInformation = $"Country name is {CountryName}, Gdp is {Gdp}, Population is {Population}, Hymn is {hymnBehavior.HymnType}";
        Console.WriteLine(countryInformation);
        return countryInformation;
    }
}
