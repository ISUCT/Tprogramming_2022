namespace CourseApp.RPGsaga;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Logger
{
    public static void Round(int round)
    {
        Console.WriteLine("Кон " + round);
    }

    public static void VS(Player[] Members)
    {
        Console.WriteLine($"{Members[(i * 2) + 1].ToString()} vs {Members[i * 2].ToString()}");
    }

    public static void Fight(Player[] Members)
    {
        Console.WriteLine($"{Members[(i * 2) + 1].ToString()} наносит урон {Members[i * 2].Damage()} {Members[i * 2].ToString()}");
    }

    public static void Death(Player[] Members)
    {
        Console.WriteLine($"{Members[(i * 2) + 1].ToString()} погибает");
    }
    public static void Winner()
    {
        Console.WriteLine($"{Members[(i * 2) + 1].ToString()} погибает");
    }
}
