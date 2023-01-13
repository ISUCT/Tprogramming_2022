namespace CourseApp
{
    using System;

    public class Archer : Player
    {
        public Archer(int health, int strength, string name)
            : base(health, strength, name, "Огненная стрела", 1)
            {
            }

        public override string ToString()
        {
            return "(Лучник) " + Name;
        }
    }
}