namespace RPGsagaApp
{
    using System;

    public class Magician : Hero
    {
        public Magician(int health, int power, string name, string ability)
            : base(health, power, name, ability)
        {
        }

        public override string AbilityDisplay()
        {
            Console.WriteLine($"Маг {Name} использует {Ability}");
            return $"{Name} пропускает ход из-за способности {Ability}";
        }
    }
}
