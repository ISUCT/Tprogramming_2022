namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Character gur = new ("zweihender");
            Character mag = new ("Magian", "crystal staf", 58);
            Console.WriteLine($"lev= {mag.Lvl}");

            mag.MaxLevel();
            mag.Damag();
            mag.Print();

            gur.Damag();
            gur.Print();
        }
    }
}
