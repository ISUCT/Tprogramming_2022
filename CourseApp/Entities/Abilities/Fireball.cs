namespace CourseApp
{
    namespace Abilities
    {
        using Players;
        using Effects;
        public class Fireball : IAbility
        {
            public int NumberUses { get; set; } = 0;
            private int MaxUses { get; set; } = 2;
            public string AbilityName { get; set; } = "Фаерболл";
            public void Spell(IPlayer myself, IPlayer enemy, int round)
            {
                IEffect generateBuff = new Buff(2, round);
                myself.MyEffects.Add(generateBuff);
                int indexEffect = myself.MyEffects.IndexOf(generateBuff);
                myself.MyEffects[indexEffect].State(myself);
                enemy.Health -= myself.Strength;
                NumberUses++;
            }

            public bool CanSpell()
            {
                if (NumberUses < MaxUses)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
