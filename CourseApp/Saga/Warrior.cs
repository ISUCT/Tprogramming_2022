namespace CourseApp
{
    using System;

    public class Warrior : Player
    {
        public Warrior(int health, int strength, string name)
            : base(health, strength, name, "Розовый удар")
            {
            }

        public override string ToString()
        {
            return "(Воинша) " + Name;
        }

        public override string Ability()
        {
            if (AbilityLeft > 0)
            {
                AbilityLeft--;
                return AbilityName;
            }
            else
            {
                return "нанесла урон";
            }
        }
    }
}