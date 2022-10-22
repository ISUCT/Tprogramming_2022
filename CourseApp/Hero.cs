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

        public int Health { get; }

        public int Power { get; }

        public string Name { get; }
    }
}
