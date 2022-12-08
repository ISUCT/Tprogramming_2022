namespace CourseApp
{
  using System;

  public class Paladin : Player
  {
    public Paladin(int health, int strength, string name)
        : base(health, strength, name, "Wrath of Holy Hammer", 1)
    {
    }

    public override string ToString()
    {
      return "(Paladin) " + Name;
    }

    public override Tuple<string, float> Ability()
    {
      if (AbilityLeft > 0)
      {
        AbilityLeft--;
        return Tuple.Create(AbilityName, (float)Math.Round(Strength * 1.7f, 2));
      }
      else
      {
        return Attack();
      }
    }
  }
}