using System;
using System.Collections.Generic;

class GameCharacter
{
    // class variables
    public static string Race = "human";
    public static string ClassType = "warrior";
    public int Level = 1;

    // instance variables
    public string Name { get; set; }

    // constructors
    public GameCharacter(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public GameCharacter(string name)
    {
        Name = name;
    }

    // methods
    public void SetRace(string race)
    {
        Race = race;
    }

    public void SetClassType(string classType)
    {
        ClassType = classType;
    }

    public void DisplayCharacterInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Race: " + Race);
        Console.WriteLine("Class: " + ClassType);
        Console.WriteLine("Level: " + Level);
    }
}
    class Program 
   {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter character name: ");
        string name = Console.ReadLine();

        List<string> classTypes = new List<string> { "Warrior", "Mage", "Rogue" };
        Console.WriteLine("Select a class: ");
        for (int i = 0; i < classTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {classTypes[i]}");
        }
        int classChoice = int.Parse(Console.ReadLine());
        string classType = classTypes[classChoice - 1];

        List<string> races = new List<string> { "Human", "Elf", "Orc" };
        Console.WriteLine("Select a race: ");
        for (int i = 0; i < races.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {races[i]}");
        }
        int raceChoice = int.Parse(Console.ReadLine());
        string race = races[raceChoice - 1];

        GameCharacter gameCharacter = new GameCharacter(name);
        gameCharacter.SetRace(race);
        gameCharacter.SetClassType(classType);
        gameCharacter.DisplayCharacterInfo();
    }
}
