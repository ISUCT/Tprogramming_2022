namespace CourseApp;

public class Noobie : Country
{
    public Noobie(int gdp, int population, string countryName)
    {
        Gdp = gdp;
        Population = population;
        CountryName = countryName;

        HymnBehavior = new Religic();
    }
}