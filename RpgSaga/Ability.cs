namespace RpgSaga
{
    public abstract class Ability
    {
        protected bool DoBlindActions(Player player, Player enemy)
        {
            if (player.playerConditions.Condition[Conditions.IsBlind])
            {
                enemy.GetDamage(0);
                player.Unblind();
                return true;
            }

            return false;
        }

        public abstract string AbilityName { get; }
        public virtual bool CanUseAbility { get; protected set; }
        public abstract void UseAbility(Player player, Player enemy);
    }
}
