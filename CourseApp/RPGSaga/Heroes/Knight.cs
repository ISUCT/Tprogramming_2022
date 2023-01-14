namespace CourseApp.RPGSaga.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CourseApp.RPGSaga;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Interface;

    public class Knight : Player
    {
        public Knight(string name, int hp, int strength)
        : base(name, hp, strength)
        {
            Abilities = new List<IAbility>() { new Hit(strength), new VengeanceStrike(strength) };
            EffectsList = new List<IAbility>();
        }

        public override void Addeffect(IAbility effect)
        {
            EffectsList.Add(effect);
        }

        public override string ToString()
        {
            return $"Knight: ({Name})";
        }

        protected override void AddAbilities()
        {
            Abilities.Clear();
            EffectsList.Clear();
            Abilities.Add(new Hit(Strength));
            Abilities.Add(new VengeanceStrike(Strength));
        }
    }
}