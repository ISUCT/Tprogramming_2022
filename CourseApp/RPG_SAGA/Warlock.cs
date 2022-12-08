namespace CourseApp
{
  using System;

  public class Warlock : Player
  {
    public Warlock(int health, int strength, string name)
        : base(health, strength, name, "Spell of Delusion", 1)
    {
    }

    public override string ToString()
    {
      return "(Warlock) " + Name;
    }

    public override Tuple<string, float> Ability()
    {
      if (AbilityLeft > 0)
      {
        AbilityLeft--;
        return Tuple.Create(AbilityName, 0.0f);
      }
      else
      {
        return Attack();
      }
    }
  }
}