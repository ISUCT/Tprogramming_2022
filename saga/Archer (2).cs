namespace CourseApp
{
    using System;

    public class Archer : Player
    {
        public Archer(int health, int strength, string name)
            : base(health, strength, name, "Cтрелы любви")
            {
            }

        public override string ToString()
        {
            return "(Лучница) " + Name;
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