namespace RPGsagaApp
{
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

        public string EnterFight(int n_kon)
        {
            return $"Кон. {n_kon}";
        }

        public string Advertisement(Hero hero1, Hero hero2)
        {
            return $"{hero1.Name} vs {hero2.Name}";
        }

        public string Action()
        {
            return $"{Name} наносит урон {Power} противнику";
        }

        public string Damage()
        {
            Health = Health - Power;
            return $"{Name} получил урон {Power} и теряет {Health} единицы жизни";
        }
    }
}
