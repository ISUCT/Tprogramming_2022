namespace CourseApp
{
    using System;

    public class Barbarian : Player
    {
        public Barbarian(int health, int strength, string name)
            : base(health, strength, name, "Ярость", 1)
        {
        }

        public override string ToString()
        {
            return "(Варвар) " + Name;
        }

        public override Tuple<string, float> Ability()
        {
            if (AbilityLeft > 0)
            {
                AbilityLeft--;
                if (CurrentHealth > 1)
                {
                    CurrentHealth = (float)Math.Round(CurrentHealth * 0.8f, 2);
                }

                return Tuple.Create(AbilityName, (float)Math.Round(Strength * 1.3f, 2));
            }
            else
            {
                return Attack();
            }
        }
    }
}
