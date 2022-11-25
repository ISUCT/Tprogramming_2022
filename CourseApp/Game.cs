namespace CourseApp
{
    public class Game
    {
        public Game()
            : this(100, 75, "Артур", "Удар возмездия")
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
    }
}
