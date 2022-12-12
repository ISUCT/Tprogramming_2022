namespace CourseApp.Abilities
{
    using CourseApp.Effects;
    using CourseApp.Players;

    public class StunStrike : IAbility
    {
        public int NumberUses { get; set; } = 0;

        public string AbilityName { get; set; } = "Оглушающий удар";

        public void Spell(IPlayer myself, IPlayer enemy, int round)
        {
            enemy.MyEffects.Add(new Stun(round));
            NumberUses++;
        }

        public bool CanSpell()
        {
            return true;
        }
    }
}
