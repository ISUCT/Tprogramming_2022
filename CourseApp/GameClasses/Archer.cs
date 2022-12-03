namespace CourseApp
{
    using System;

    public class Archer : Player
    {
        public Archer(int health, int strength, string name)
            : base(health, strength, name, "Огненные стрелы", 1)
            {
            }

        public override string ToString()
        {
            return "(Лучник) " + Name;
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