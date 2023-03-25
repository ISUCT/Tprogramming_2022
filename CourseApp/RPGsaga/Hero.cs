namespace RPGsagaApp
{
    using System;

    public abstract class Hero
    {
        private int defaultHealth;

        public Hero(int health, int power, string name, string ability)
        {
            Health = health;
            defaultHealth = Health;
            Power = power;
            Name = name;
            Ability = ability;
        }

        public int Health { get; set; }

        public int Power { get; set; }

        public string Name { get; set; }

        public string Ability { get; set; }

        public abstract string AbilityDisplay();

        public void Action()
        {
            Console.WriteLine($"{Name} наносит урон {Power} противнику");
        }

        public void Damage()
        {
            Health = Health - Power;
            Console.WriteLine($"{Name} получил урон {Power} и теряет {Health} единицы жизни");
        }
    }
}
