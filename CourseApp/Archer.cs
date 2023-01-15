namespace CourseApp
{
    using System.Collections.Generic;

    public class Archer : Entity
    {
        public Archer(int health, int damage, string name)
        : base(health, damage, name, new FireArrows())
        {
        }
    }
}