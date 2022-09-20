namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Country Vitilia = new Country();
            Vitilia.PerformHymn();
            Vitilia.HymnBehavior = new National();
            Vitilia.PerformHymn();
            Vitilia.PrintCountryInformation();
    
            Country Vovia = new Country("Vovia", 1000, 3000, new Religic());
            Vovia.PerformHymn();
            Vovia.HymnBehavior = new Literary();
            Vovia.PerformHymn();
            Vovia.PrintCountryInformation();


            Vitilia.PopulationCensus();
            Vovia.PopulationCensus();
        }
    }
}
