namespace AutoApp
{
    public abstract class Automobile
    {
        public Automobile(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Display();

        public string Move()
        {
            return $"{Name} движется";
        }
    }
}
