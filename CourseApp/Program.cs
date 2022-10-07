using System;
using CourseApp;

public class Program
{
    public static void Main(string[] args)
    {
        Human male = new Male(20, 177, 99);
        Human female = new Female(25);

        var humanArray = new Human[] { male, female };

        foreach (var human in humanArray)
        {
            var tostring = human.ToString();
            Console.WriteLine($"{tostring}");
            human.Show();
            human.Midlle_Age();
            human.Average_Height();
            human.Average_Weight();
            Console.WriteLine();
        }
    }
}