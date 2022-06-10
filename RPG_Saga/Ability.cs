namespace RpgSaga
{
    public abstract class Ability
    {
        public abstract string AbilityName { get; set; }
        public virtual bool CanUseAbility { get; protected set; }

        public abstract void UseAbility(Player player, Player enemy);
    }
}
