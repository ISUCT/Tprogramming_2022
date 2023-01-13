namespace CourseApp
{
  using System;

  public class Shaman : Player
  {
    public Shaman(int health, int strength, string name)
        : base(health, strength, name, "Divine Healing", 1)
    {
    }

    public override string ToString()
    {
      return "(Shaman) " + Name;
    }

    public override Tuple<string, float> Ability()
    {
      if (AbilityLeft > 0)
      {
        AbilityLeft--;
        CurrentHealth += 26;
        return Tuple.Create(AbilityName, 26f);
      }
      else
      {
        return Attack();
      }
    }
  }
}