namespace CourseApp.RPGsaga

using System;
using System.Collections.Generic;

public abstract class Player
{
    public Player(int health, int force, string name, string abilityName)
    {
        this.Force = force;
        this.Health = health;
        this.Name = name;
        this.AbilityName = abilityName;
    }

    public double Force { get; set; }

    public int Health { get; set; }

    public string Name { get; set; }

    public string AbilityName { get; set; }

    public bool Death()
    {
        if (Health == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}