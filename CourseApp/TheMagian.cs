namespace CourseApp;

using System;

public class TheMagian : Character
{
    private int GrupOfOpponent;
    
    public TheMagian(string name, string typeOfWeapon, int lvl)
        : base(name, typeOfWeapon, lvl)
    {
    }

    public void Opponent(int GrupOfOpponent)
    {
        if (GrupOfOpponent < 40)
        {
            Console.WriteLine($"Им не нужна моя помощь");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Им нужна моя помощь");
            Console.WriteLine();
        }
    }

    public override string Guild()
    {
        return "я состою в гильдии Банши";
    }

    public override string GetInfo()
    {
        return $"Я служу для защиты нашего прекрасного замка ";
    }
}