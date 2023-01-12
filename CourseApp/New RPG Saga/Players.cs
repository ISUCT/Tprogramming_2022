namespace CourseApp.RPG_Saga
{
    using System;

    public abstract class Players
    {
        private Random randomStats = new Random();

        public Players(string name)
        {
            Health = randomStats.Next(60, 100);
            Strength = randomStats.Next(20, 50);
            Name = name;
            Ult = false;
        }

        public int Health { get; set; }

        public int Strength { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public bool Ult { get; set; }

        public virtual void Ultimate()
        {
            Ult = true;
        }

        public virtual int Punch()
        {
            return Strength;
        }
    }
}

