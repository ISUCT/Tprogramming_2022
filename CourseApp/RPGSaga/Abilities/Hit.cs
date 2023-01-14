namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interface;

    public class Hit : IAbility
    {
        public Hit(int dmg)
        {
            Name = "Hit";
            Damage = dmg;
            UsageLimit = 999999;
            SkippingMove = false;
            IsFire = false;
            Duration = 1;
        }

        public string Name { get; }

        public double Damage { get; set; }

        public int UsageLimit { get; set; }

        public bool SkippingMove { get; set; }

        public bool IsFire { get; }

        public int Duration { get; set; }
    }
}
