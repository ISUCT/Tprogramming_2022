namespace RPGsagaApp
{
    using System;

    public class Archer : Hero
    {
        public Archer(int health, int power, string name, string ability)
            : base(health, power, name, ability)
        {
        }

        public override string AbilityDisplay()
        {
            Console.WriteLine($"Лучник {Name} использует {Ability}");
            Health = Health - 2;
            return $" {Name} периодически получает урон {Health} от способности {Ability}";
        }
    }
}
