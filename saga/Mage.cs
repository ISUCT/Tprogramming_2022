namespace CourseApp
{
    using System;

    public class Mage : Player
    {
        public Mage(int health, int strength, string name)
            : base(health, strength, name, "Заворожение", 1)
            {
            }

        public override string ToString()
        {
            return "(Маг) " + Name;
        }
    }
}