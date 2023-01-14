namespace CourseApp.RPGSaga.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CourseApp.RPGSaga;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Interface;
    using Logger = System.Console;

    public class Wizard : Player
    {
        public Wizard(string name, int hp, int strength)
       : base(name, hp, strength)
       {
        Abilities = new List<IAbility>() { new Hit(strength), new Spellbinding() };
        EffectsList = new List<IAbility>();
       }

        public override void Addeffect(IAbility effect)
        {
            EffectsList.Add(effect);
        }

        public override string ToString()
        {
            return $"Wizard: ({Name})";
        }

        protected override void AddAbilities()
        {
            Abilities.Clear();
            EffectsList.Clear();
            Abilities.Add(new Hit(Strength));
            Abilities.Add(new Spellbinding());
        }
    }
}