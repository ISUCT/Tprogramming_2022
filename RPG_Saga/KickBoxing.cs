namespace RpgSaga
{
    public class KickBoxing : Ability
    {
        public override string AbilityName { get; set; }
        public override bool CanUseAbility { get; protected set; }

        public KickBoxing()
        {
            AbilityName = "Кикбоксинг";
            CanUseAbility = true;
        }

        public override void UseAbility(Player player, Player enemy)
        {
            if (player.IsBlind)
            {
                player.Unblind();
                return;
            }

            int superDamage = player.Strength + (int)(player.Strength * 0.3);
            enemy.GetDamage(superDamage);
        }
    } 
}
