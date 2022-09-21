namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Country vitilia = new Country();
            vitilia.PerformHymn();
            vitilia.HymnBehavior = new National();
            vitilia.PerformHymn();
            vitilia.PrintCountryInformation();

            Country vovia = new Country("Vovia", 1000, 3000, new Religic());
            vovia.PerformHymn();
            vovia.HymnBehavior = new Literary();
            vovia.PerformHymn();
            vovia.PrintCountryInformation();

            vitilia.PopulationCensus();
            vovia.PopulationCensus();
        }
    }
}
