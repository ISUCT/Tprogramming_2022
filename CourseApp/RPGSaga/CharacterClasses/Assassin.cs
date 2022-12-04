namespace CourseApp
{
    using System;

    public class Assassin : Player
    {
        public Assassin(int health, int strength, string name)
            : base(health, strength, name, "Кровавый удар", 1)
        {
        }

        public override string ToString()
        {
            return "(Асасин) " + Name;
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
