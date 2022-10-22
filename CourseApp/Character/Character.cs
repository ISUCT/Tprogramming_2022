namespace Character;

using System;

public abstract class Character
{
    private int level;

    public Character(string name, string typeOfWeapon, int lvl)
    {
        this.Name = name;
        this.TypeOfWeapon = typeOfWeapon;
        this.Lvl = lvl;
    }

    public int Lvl
    {
        get
        {
            return level;
        }

        set
        {
            if (level < value)
            {
                level = value;
            }
        }
    }

    public string TypeOfWeapon { get; set; }

    public string Name { get; set; }

    public void Print()
    {
        Console.Write($"{Name} {Lvl} {TypeOfWeapon}");
    }

    public virtual string Guild()
    {
        return "1535";
    }

    /*public void MaxLevel()
    {
        Console.WriteLine($"Ваш уровень {Lvl} /99");
    }

    public void Damag()
    {
        Console.WriteLine($"Вам выпало легендарный оружие {TypeOfWeapon}");
    }*/

    public virtual string GetInfo()
    {
        return "54891";
    }
}
