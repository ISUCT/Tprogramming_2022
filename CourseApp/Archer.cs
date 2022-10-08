namespace CourseApp;

using System;

public class Archer : Character
{
    public Archer(string clas, string typeOfWeapon, int lvl)
        : base(clas, typeOfWeapon, lvl)
    {
    }

    private string bw = "Bow of the erd tree";

    public void Bow(string bow)
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

    public void Ability(int arrows)
    {
        if (arrows < 90)
        {
            Console.WriteLine("Тебе разрешено защищать только стены города");
        }
        else
        {
            Console.WriteLine("Тебе разрешено защищать саму принцессу");
        }
    }
}