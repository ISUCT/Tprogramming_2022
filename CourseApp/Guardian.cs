namespace CourseApp;

using System;

public class Guardian : Character
{
    public Guardian(string typeOfWeapon, int lvl)
        : base(typeOfWeapon, lvl)
    {
    }

    public void Protect(bool protect)
    {
        if (protect != true)
        {
            Console.WriteLine("Я не защищаю принцессу");
        }
        else
        {
            Console.WriteLine("Я защищаю принцессу");
        }
    }
}