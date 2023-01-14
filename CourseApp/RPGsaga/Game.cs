namespace RPGsagaApp
{
    using System;

    public class Game
    {
        public Game()
        {
        }

        public Game(int health, int power, string name, string ability)
        {
            Health = health;
            Power = power;
            Name = name;
            Ability = ability;
        }

        public int Health { get; set; }

        public int Power { get; set; }

        public string Name { get; set; }

        public string Ability { get; set; }

        public string Print()
        {
            return $"Здоровье: {Health}  Сила: {Power}  Имя: {Name}  Способность: {Ability}";
        }

        public Hero Fight(Hero hero1, Hero hero2, Hero n_round, int n_kon)
        {
            n_round.EnterFight(n_kon);
            n_round.Advertisement(hero1, hero2);
            hero1.Action();
            hero2.Damage();
            if (hero2.Health <= 0)
            {
                Console.WriteLine($"{hero2.Name} погибает");
                return hero1;
            }

            hero2.Action();
            hero1.Damage();
            if (hero1.Health <= 0)
            {
                Console.WriteLine($"{hero1.Name} погибает");
                return hero2;
            }

            return hero1;
        }
    }
}
