namespace Character;

using System;

public class Guardian : Character
{
    public Guardian(string name, string typeOfWeapon, int lvl)
        : base(name, typeOfWeapon, lvl)
    {
    }

    public void Protect(bool protect)
    {
        if (protect != true)
        {
            Console.WriteLine("Я не защищаю принцессу");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Я защищаю принцессу");
            Console.WriteLine();
        }
    }

    public override string Guild()
    {
        return "я состою в гильдии Пылающий Вепрь";
    }

    public override string GetInfo()
    {
        return $"Я работаю в элитных войсках короля Людовика 2 ";
    }

    public override string ToString()
    {
        return "Как хорошо, что меня ещё не уволили)";
    }
}