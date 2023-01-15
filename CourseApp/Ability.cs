namespace CourseApp
{
    public enum AbilityTypes
    {
        Skip,
        Attack,
        Blind,
    }

    public abstract class Ability
    {
        public Ability(string abilityName, int damage, int steps, AbilityTypes type)
        {
            AbilityName = abilityName;
            Damage = damage;
            StepsDuration = steps;
            CanUse = true;
            Type = type;
        }

        public AbilityTypes Type { get; }

        public string AbilityName { get; }

        public int Damage { get; }

        public int StepsDuration { get; set; }

        public bool CanUse { get; set; }

        public virtual Ability UseAbility()
        {
            return this;
        }
    }
}