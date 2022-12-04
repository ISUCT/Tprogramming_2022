namespace CourseApp.RPGSaga.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Interface;

    public abstract class Player
    {
        private int strength;

        public Player(string name, int hp, int strength)
        {
            Name = name;
            HP = hp;
            Strength = strength;
            IsDead = false;
            IsFire = false;
        }

        public string Name { get; set; }

        public int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public abstract Player Opponent { get; set; }

        public bool IsDead { get; set; }

        public bool IsFire { get; set; }

        public int HP { get; protected set; }

        public abstract void MakeMove();

        public abstract void DealDamage();

        public abstract void Addeffect(IAbility effect);

        public abstract void SetDefaultValues();
    }
}