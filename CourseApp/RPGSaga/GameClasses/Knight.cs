namespace CourseApp
{
    using System;

    public class Knight : Player
    {
        public Knight(int health, int strength, string name)
            : base(health, strength, name, "Удар возмездия", 1)
        {
        }

        public override string ToString()
        {
            return "(Рыцарь) " + Name;
        }

        public override Tuple<string, float> Ability()
        {
            if (AbilityLeft > 0)
            {
                AbilityLeft--;
                return Tuple.Create(AbilityName, Strength * 1.3f);
            }
            else
            {
                return Attack();
            }
        }
    }
}