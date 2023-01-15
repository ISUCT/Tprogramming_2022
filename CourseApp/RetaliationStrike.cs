namespace CourseApp
{
    public class RetaliationStrike : Ability
    {
        public RetaliationStrike(int damage)
        : base("Удар возмездия", damage, 1, AbilityTypes.Attack)
        {
        }
    }
}