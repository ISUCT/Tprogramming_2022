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
            return $"{Name} получил урон {Power} и теряет {Health} единицы жизни";
        }

        public string KnightAbiltiy()
        {
            Health = Health - (Power + 30);
            return $"{Name} теряет {Health} единицы жизни";
        }

        public string ArcherAbility()
        {
            Health = Health - 2;
            return $"{Name} теряет {Health - 2} единицы жизни";
        }

        public string MagicianAbility()
        {
            return $"{Name} пропускает ход";
        }
    }
}
