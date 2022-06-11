namespace RpgSaga
{
    public class Rocking : Ability
    {
        public override string AbilityName { get; set; }
        public override bool CanUseAbility { get; protected set; }

        public Rocking()
        {
            AbilityName = "Качание";
            CanUseAbility = true;
        }

        public override void UseAbility(Player player, Player enemy)
        {
            enemy.Blind();
            enemy.GetDamage(0);
        }
    } 
}
