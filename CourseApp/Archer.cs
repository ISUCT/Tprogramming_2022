namespace CourseApp;

using System;

public class Archer : Character
{
    private static string bw = "Bow of the erd tree";

    public Archer(string name, string typeOfWeapon, int lvl)
        : base(name, typeOfWeapon, lvl)
    {
    }

    public static void Bow(string bow)
    {
        if (bow == bw)
        {
            Ability(100);
        }
        else
        {
            Ability(80);
        }
    }

    public static void Ability(int arrows)
    {
        if (arrows < 90)
        {
            Console.WriteLine("Azir тебе разрешено защищать только стены города");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Azir тебе разрешено защищать саму принцессу");
            Console.WriteLine();
        }
    }

    public override string Guild()
    {
        return "я состою в гильдии Милость Дриады";
    }

    public override string GetInfo()
    {
        return $"Я заступил на службу в 12:00 ";
    }

    /*public new void Print()
    {
        Console.WriteLine($"{Name} {TypeOfWeapon}");
    }*/
}