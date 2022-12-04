namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interface;

    public class Spellbinding : IAbility
    {
        public Spellbinding()
        {
            Name = "Spellbinding";
            Damage = 0;
            UsageLimit = 1;
            SkippingMove = true;
            IsFire = false;
            Duration = 1;
        }

        public string Name { get; }

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
