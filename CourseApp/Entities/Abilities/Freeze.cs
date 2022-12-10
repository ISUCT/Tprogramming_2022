namespace CourseApp
{
    namespace Abilities
    {
        using Players;
        using Effects;
        public class Freeze : IAbility
        {
            public int NumberUses { get; set; } = 0;
            public string AbilityName { get; set; } = "Заворожение";
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
}
