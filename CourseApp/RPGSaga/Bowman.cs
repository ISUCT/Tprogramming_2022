namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bowman : Player
    {
        public Bowman()
        {
            Name = "Лучник";
            Maxhealth = 50;
            Power = 7;
        }

        public Bowman(string name, double maxhealth, double power)
        {
            Name = name;
            Maxhealth = maxhealth;
            Power = power;
        }

        public double Firearrows()
        {
            var damage = 0;
            Console.WriteLine($"{Name} стреляет огненной стрелой");
            return damage;
        }
    }
}