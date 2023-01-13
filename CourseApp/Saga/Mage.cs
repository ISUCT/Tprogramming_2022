namespace CourseApp
{
    using System;

    public class Mage : Player
    {
        public Mage(int health, int strength, string name)
            : base(health, strength, name, "Заколдованная пыль")
            {
            }

        public override string ToString()
        {
            return "(Волшебница) " + Name;
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