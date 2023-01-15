namespace CourseApp
{
    using System.Collections.Generic;

    public class Knight : Entity
    {
        public Knight(int health, int damage, string name)
        : base(health, damage, name, new RetaliationStrike((int)(damage + ((damage / 10) * 3))))
        {
        }
    }
}