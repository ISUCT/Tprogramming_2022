namespace CourseApp;

using System;

public class Character
{
    private int level;

    private string clas;

    public Character(string typeOfWeapon)
        : this("guardian", typeOfWeapon, 60)
    {
    }

    public Character(string clas, string typeOfWeapon, int lvl)
    {
        this.clas = clas;
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

    public void Print()
    {
        Console.WriteLine($"Ваши характеристи на данный момент \n {clas} {Lvl} {TypeOfWeapon}");
    }

    public void MaxLevel()
    {
        Console.WriteLine($"Ваш уровень {Lvl} /99");
    }

    public void Damag()
    {
        Console.WriteLine($"Вам выпало легендарный оружие {TypeOfWeapon}");
    }
}
