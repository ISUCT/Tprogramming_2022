namespace CourseApp.RPGSaga.Abilities
{
    using System;
    using CourseApp.RPGSaga.Interface;

    public class FireArrows : IAbility
    {
        public FireArrows()
        {
            Name = "Fire Arrows";
            Damage = 0;
            UsageLimit = 1;
            SkippingMove = false;
            IsFire = true;
            Duration = 100000;
        }

        public string Name { get; }

        public double Damage { get; set; }

        public int UsageLimit { get; set; }

        public bool SkippingMove { get; set; }

        public bool IsFire { get; }

        public int Duration { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}