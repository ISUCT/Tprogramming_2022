namespace CourseApp.RPGsaga

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
    public void Use()
    {
        if (AbilityUse == false)
        {
            AbilityUse = true;
        }
    }

    public int Attack()
    {
        if (AbilityUse == true)
        {
            return force *= 0.3;
        }
    }
}