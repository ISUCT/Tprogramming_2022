namespace CourseApp;

public class Smowia : Country
{
    public Smowia(int gdp, int population, string countryName)
    {
        Gdp = gdp;
        Population = population;
        CountryName = countryName;

        HymnBehavior = new Literary();
    }
}