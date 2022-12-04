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
                return Tuple.Create(AbilityName, (float)Math.Round(Strength * 1.3f, 2));
            }
            else
            {
                return Attack();
            }
        }
    }
}