namespace RpgSaga
{
    public class Blinding : Ability
    {
        public override string AbilityName { get; }
        public override bool CanUseAbility { get; protected set; }

        public Blinding()
        {
            AbilityName = "Ослепление";
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
