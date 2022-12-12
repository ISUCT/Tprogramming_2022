namespace CourseApp.Abilities
{
    using CourseApp.Effects;
    using CourseApp.Players;

    public class VengeanceStrike : IAbility
    {
        public int NumberUses { get; set; } = 0;

        public string AbilityName { get; set; } = "Удар возмездия";

        public void Spell(IPlayer myself, IPlayer enemy, int round)
        {
            IEffect generateBuff = new Buff(1.3, round);
            myself.MyEffects.Add(generateBuff);
            int indexEffect = myself.MyEffects.IndexOf(generateBuff);
            myself.MyEffects[indexEffect].State(myself);
            enemy.Health -= myself.Strength;
            NumberUses++;
        }

        public bool CanSpell()
        {
            return true;
        }
    }
}
