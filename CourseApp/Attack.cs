namespace CourseApp
{
    public class Attack : Ability
    {
        public Attack(int damage)
        : base("Атака", damage, 1, AbilityTypes.Attack)
        {
        }
    }
}