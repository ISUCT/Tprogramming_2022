namespace CourseApp.RPGsaga;

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

    public virtual string ToString()
    {
        return "(Герой) " + Name;
    }

    public bool AbilityUse = false;

    public virtual void Ability(string AbilityUse)
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

    public void NewHealth(int damage)
    {
        health -= damage;
    }

    public int Damage()
    {
        return force;
    }

    public bool Death()
    {
        if (health == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
