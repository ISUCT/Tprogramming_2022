namespace RpgSaga
{
    public class PenetratingArrows : Ability
    {
        public override string AbilityName { get; set; }
        public override bool CanUseAbility { get; protected set; }

        public PenetratingArrows()
        {
            AbilityName = "Пронзающие огненные стрелы";
            CanUseAbility = true;
        }

        public override void UseAbility(Player player, Player enemy)
        {
            if (player.IsBlind)
            {
                enemy.GetDamage(0);
                player.Unblind();
                return;
            }

            enemy.Burn();
            CanUseAbility = false;
        }
    }
}
