using System;

class Cat
{
    private int age;
    private string name;
    private string breed;

    public Cat()
    {
        this.age = 0;
        this.name = "unknown";
        this.breed = "unknown";
    }

    public Cat(int age, string name, string breed)
    {
        this.age = age;
        this.name = name;
        this.breed = breed;
    }

    public int GetAge()
    {
        return this.age;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetBreed()
    {
        return this.breed;
    }

    public void SetBreed(string breed)
    {
        this.breed = breed;
    }

    public void Purr()
    {
        Console.WriteLine("Purrrrrrrrrrr...");
    }

    public void meow()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Cat myCat = new Cat(3, "Whiskers", "Siamese");
        Console.WriteLine("My cat's name is " + myCat.GetName());
        myCat.meow();
        myCat.Purr();
    }
}
