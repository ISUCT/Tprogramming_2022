namespace RpgSaga
{
    public class FireArrows : Ability
    {
        public override string AbilityName { get; }
        public override bool CanUseAbility { get; protected set; }

        public FireArrows()
        {
            AbilityName = "Огненные стрелы";
            CanUseAbility = true;
        }

        public override void UseAbility(Player player, Player enemy)
        {
            if (DoBlindActions(player, enemy))
            {
                return;
            }

            enemy.Burn();
            CanUseAbility = false;
        }
    }
}
