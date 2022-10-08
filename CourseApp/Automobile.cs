namespace CourseApp
{
    using System;

    public abstract class Automobile
    {
        public Automobile(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Display();

        public void Move()
        {
            Console.WriteLine($"{Name} движется");
        }
    }
}
