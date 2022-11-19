namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Knight : Player
    {
        public Knight()
        {
            Name = "Рыцарь";
            Maxhealth = 80;
            Power = 5;
        }

        public Knight(string name, double maxhealth, double power)
        {
            Name = name;
            Maxhealth = maxhealth;
            Power = power;
        }

        public double VengStrike()
        {
            var damage = Power * 1.3;
            Console.WriteLine($"{Name} наносит {damage} урона");
            return damage;
        }
    }
}