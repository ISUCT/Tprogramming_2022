namespace CourseApp.Abilities
{
    using CourseApp.Effects;
    using CourseApp.Players;

    public class FireArrows : IAbility
    {
        public string AbilityName { get; set; } = "Огненные стрелы";

        public int NumberUses { get; set; } = 0;

        private int MaxUses { get; set; } = 1;

        public void Spell(IPlayer myself, IPlayer enemy, int round)
        {
            enemy.MyEffects.Add(new LongDamage(5, round));
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
