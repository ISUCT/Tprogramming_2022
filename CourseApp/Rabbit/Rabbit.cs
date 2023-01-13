namespace CourseApp;

using System;

public class Rabbit : Animals, IEat
{
    private string movement;
    private string eat;
    private int age;
    private string color;
    private string gender;
    private string info;

    public Rabbit(int age, string color, string gender)
        : base(age, color, gender)
    {
        this.gender = gender;
        this.age = age;
        this.color = color;
        Name = "No_Name";
    }

    public string Name { get; set; }

    public void SwitchName(string newName)
    {
        Name = newName;
        Console.Write($"Name for your rabbit: {Name}");
    }

    public override string GetInfo()
    {
        info = @$"Animal: Rabbit
Age: {age}
Gender: {gender}
Color: {color}
Name: {Name}";
        Console.WriteLine(info);
        return info;
    }

    public override string Move()
    {
        movement = "Rabbit jump";
        Console.WriteLine(movement);
        return movement;
    }

    public string Eat(string food)
    {
        eat = $"Rabbit to eat {food}";
        Console.WriteLine(eat);
        return eat;
    }
}