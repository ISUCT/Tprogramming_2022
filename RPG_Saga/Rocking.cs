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
            if (DoBlindActions(player, enemy))
            {
                return;
            }

            enemy.Blind();
        }
    } 
}
