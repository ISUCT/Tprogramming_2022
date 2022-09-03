namespace RpgSaga
{
    public class KickBoxing : Ability
    {
        public override string AbilityName { get; }
        public override bool CanUseAbility { get; protected set; }

        public KickBoxing()
        {
            AbilityName = "Кикбоксинг";
            CanUseAbility = true;
        }

        public override void UseAbility(Player player, Player enemy)
        {
            if (DoBlindActions(player, enemy))
            {
                return;
            }

            int superDamage = player.Strength + (int)(player.Strength * 0.3);
            enemy.GetDamage(superDamage);
        }
    } 
}
