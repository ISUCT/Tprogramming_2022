namespace CourseApp
{   
    namespace Abilities
    {
        using Players;
        using Effects;
        public interface IAbility
        {
            int NumberUses { get; set; }
            string AbilityName { get; set; }
            void Spell(IPlayer myself, IPlayer enemy, int round);
            bool CanSpell();
        } 
    }
}

