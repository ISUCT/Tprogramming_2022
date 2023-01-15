namespace CourseApp
{
    public class FireArrows : Ability
    {
        public FireArrows()
        : base("Огненные стрелы", 2, 9999, AbilityTypes.Attack)
        {
        }

        public override Ability UseAbility()
        {
            CanUse = false;
            return this;
        }
    }
}