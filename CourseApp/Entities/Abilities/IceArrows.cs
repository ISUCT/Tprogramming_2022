namespace CourseApp
{
    namespace Abilities
    {
        using Players;
        using Effects;
        public class IceArrows : IAbility
        {
            public int NumberUses { get; set; } = 0;
            private int MaxUses { get; set; } = 1;
            public string AbilityName { get; set; } = "Ледяные стрелы";
            public void Spell(IPlayer myself, IPlayer enemy, int round)
            {
                enemy.MyEffects.Add(new LongDamage(10, round));
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
