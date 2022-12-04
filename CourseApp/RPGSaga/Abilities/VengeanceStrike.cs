namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interface;

    public class VengeanceStrike : IAbility
    {
        public VengeanceStrike(int dmg)
        {
            Name = "Vengeance Strike";
            Damage_Multiplier = 1.3;
            Damage = dmg * Damage_Multiplier;
            UsageLimit = 1;
            SkippingMove = false;
            IsFire = false;
            Duration = 1;
        }

        public string Name { get; }

        public double Damage_Multiplier { get; set; }

        public double Damage { get; set; }

        public int UsageLimit { get; set; }

        public bool SkippingMove { get; set; }

        public bool IsFire { get; }

        public int Duration { get; set; }

        public bool СheckUsageLimit()
        {
            if (UsageLimit >= 1)
            {
                return true;
            }
            else
            {
                 return false;
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
