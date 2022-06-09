namespace RpgSaga
{
    public interface Ability
    {
        public abstract string AbilityName { get; set; }
        public void UseAbility(Player enemy);
    }
}
