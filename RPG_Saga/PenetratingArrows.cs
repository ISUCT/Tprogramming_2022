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
            enemy.Burn();
            enemy.GetDamage(0);
            CanUseAbility = false;
        }
    } 
}
