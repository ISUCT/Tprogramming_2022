namespace CourseApp;

using System;

public class Character
{
    private int level;

    private string clas;
    public int Lvl {
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
    private string TypeOfWeapon;

    public Character(string TypeOfWeapon) : this("guardian", TypeOfWeapon, 60)
    {}
    public Character(string clas, string TypeOfWeapon, int Lvl)
    {
        this.clas = clas;
        this.TypeOfWeapon = TypeOfWeapon;
        this.Lvl = Lvl;
    }
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
