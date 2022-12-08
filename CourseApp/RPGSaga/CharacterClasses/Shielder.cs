namespace CourseApp
{
    using System;

    public class Shielder : Player
    {
        public Shielder(int health, int strength, string name)
            : base(health, strength, name, "Удар щитом", 1)
        {
        }

        public override string ToString()
        {
            return "(Щитовик) " + Name;
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