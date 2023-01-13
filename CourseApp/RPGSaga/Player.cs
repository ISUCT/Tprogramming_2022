namespace CourseApp.RPGSaga
{
    using System;

    public abstract class Player
    {
        private Random randomValue = new Random();

        public Player()
        {
            Health = randomValue.Next(40, 100);
            Strength = randomValue.Next(20, 40);
        }

        public PlayerTypes MyProperty { get; set; }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Strength { get; set; }

        public virtual void Ultimate()
        {
        }

        public abstract int GiveDamage();

        public virtual void GetDamage(int damage)
        {
            Health -= damage;
        }
    }
}
