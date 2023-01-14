namespace CourseApp.RPGsaga;

using System;
using System.Collections.Generic;

public class Archer : Player
{
    public Archer(int health, int force, string name, string abilityName)
        : base(health, force, name, "Огненные стрелы")
    {
    }

    public bool AbilityUse = false;

    public override string ToString()
    {
        return "(Лучник) " + Name;
    }

    public override int Ability(string AbilityUse)
    {
        Random rnd = new Random();
        int prob = (int)rnd.NextInt64(1, 10);
        switch (prob)
        {
            case 1:
                return AbilityUse = true;                
            default:
                return AbilityUse = false;
        }
    }
}
