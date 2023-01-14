namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interface;

    public class VengeanceStrike : IAbility
    {
        public VengeanceStrike(int dmg)
        {
            Name = "Vengeance Strike";
            DamageMultiplier = 1.3;
            Damage = dmg * DamageMultiplier;
            UsageLimit = 1;
            SkippingMove = false;
            IsFire = false;
            Duration = 1;
        }

        public string Name { get; }

        public double DamageMultiplier { get; set; }

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
