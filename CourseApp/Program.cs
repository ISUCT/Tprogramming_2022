namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Country floowy = new Floowy(300, 1000, "Floowy");
            floowy.PerformHymn();
            floowy.SetHymnBehavior(new Religic());
            floowy.PerformHymn();

            Country noobie = new Noobie(150, 10_000, "Noobie");
            noobie.PerformHymn();
            noobie.SetHymnBehavior(new Literary());
            noobie.PerformHymn();

            Country smowia = new Smowia(10_000, 100_000, "Smowia");
            smowia.PerformHymn();
            smowia.SetHymnBehavior(new National());
            smowia.PerformHymn();
        }
    }
}
