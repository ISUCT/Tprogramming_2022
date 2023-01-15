namespace CourseApp
{
    using System.Collections.Generic;

    public class Wizard : Entity
    {
        public Wizard(int health, int damage, string name)
        : base(health, damage, name, new Blind())
        {
        }
    }
}