namespace CourseApp.RPGsaga

using System;
using System.Collections.Generic;

public class Wizard : Player
{
    public Wizard(int health, int force, string name, string abilityName)
        : base(health, force, name, "Удар возмездия")
    {
    }

    public bool AbilityUse = false;
    public string ToString()
    {
        return "(Волшебник) " + Name;
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
            damage = 0;
        }
    }
}