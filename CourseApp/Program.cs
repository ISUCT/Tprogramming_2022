namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Character gur = new ("zweihender", 60);
            Character mag = new ("Magian", "crystal staf", 58);
            Console.WriteLine($"lev= {mag.Lvl}");
            Guardian guardian = new Guardian("zweihender", 90);
            Archer archer = new Archer("Archer", "Black Onion", 79);

            mag.MaxLevel();
            mag.Damag();
            mag.Print();

            gur.Damag();
            gur.Print();
            guardian.Print();
            guardian.Protect(true);
            
            archer.Bow("Bow of the erd tree");
        }
    }
}
