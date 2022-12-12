namespace CourseApp.Abilities
{
    using CourseApp.Effects;
    using CourseApp.Players;

    public class IceArrows : IAbility
    {
        public int NumberUses { get; set; } = 0;

        public string AbilityName { get; set; } = "Ледяные стрелы";

        private int MaxUses { get; set; } = 1;

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
