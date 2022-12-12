namespace CourseApp.Players
{
    using System.Collections.Generic;
    using CourseApp.Abilities;
    using CourseApp.Effects;

    public interface IPlayer
    {
        string Name { get; set; }

        int Strength { get; set; }

        int Health { get; set; }

        List<IAbility> Abilities { get; set; }

        int CurrentAbility { get; set; }

        List<IEffect> MyEffects { get; set; }

        IEffect NormalState { get; set; }

        string ClassName { get; set; }

        void TakingDamage(int damage);

        void AttackEnemy(IPlayer enemy);

        void EnterCurrentAbility();

        bool CanUltimate();

        int Ultimate(IPlayer myself, IPlayer enemy, int round);

        void Effect(IPlayer myself);

        void DeleteEffect(IPlayer myself, int round, int numberPlayer);

        void RestoreAfterBattle();
    }
}
