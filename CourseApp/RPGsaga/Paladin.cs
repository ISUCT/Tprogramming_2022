namespace CourseApp.RPGsaga;

using System;
using System.Collections.Generic;

public class Paladin : Player
{
    public Paladin(int health, int force, string name, string abilityName)
        : base(health, force, name, "Удар возмездия")
    {
    }

    public bool AbilityUse = false;


    public string ToString()
    {
        return "(Паладин) " + Name;
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
