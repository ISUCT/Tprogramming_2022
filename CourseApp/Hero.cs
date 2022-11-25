namespace CourseApp
{
    public abstract class Hero
    {
        public Hero(int health, int power, string name)
        {
            Health = health;
            Power = power;
            Name = name;
        }

        public int Health { get; set; }

        public int Power { get; set; }

        public string Name { get; set; }

        public abstract string AbilityDisplay();

        public string Action()
        {
            return $"{Name} наносит урон {Power} противнику";
        }

        public string Damage()
        {
            Health = Health - Power;
            return $"{Name} получил урон {Power} и теряет {Health - Power} единицы жизни";
        }
    }
}
