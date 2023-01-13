using System;

abstract class Animal
{
    protected int age;
    protected string sound;

  
    public Animal(int age)
    {
        this.age = age;
    }

  
    public void SetAge(int age)
    {
        this.age = age;
    }

    public abstract void MakeSound();

    public override string ToString()
    {
        return $"Age: {age}, Sound: {sound}";
    }
}

class Cat : Animal
{
    public Cat(int age) : base(age)
    {
        sound = "Meow";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Dog : Animal
{
    public Dog(int age) : base(age)
    {
        sound = "Woof";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}

class Test
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[] { new Cat(3), new Dog(5) };
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            Console.WriteLine(animal.ToString());
        }
    }
}
