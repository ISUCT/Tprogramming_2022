namespace CourseApp.RPGsaga

using System;
using System.Collections.Generic;

public class Archer : Player
{
    public Archer(int health, int force, string name, string abilityName)
        : base(health, force, name, "Огненные стрелы")
    {
    }

    public bool AbilityUse = false;

    public string ToString()
    {
        return "(Лучник) " + Name;
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
            return force += 2;
        }
        else
            return force;
    }
}
