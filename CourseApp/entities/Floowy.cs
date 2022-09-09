namespace CourseApp;

public class Floowy : Country
{
    public Floowy(int gdp, int population, string countryName)
    {
        Gdp = gdp;
        Population = population;
        CountryName = countryName;

        HymnBehavior = new National();
    }
}