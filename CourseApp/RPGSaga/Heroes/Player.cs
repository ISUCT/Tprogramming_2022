namespace CourseApp.RPGSaga.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Interface;

    public abstract class Player
    {
        private bool isSkip;
        private int strength;
        private Player opponent;
        private List<IAbility> abilities;
        private List<IAbility> effectsList;

        public Player(string name, int hp, int strength)
        {
            Name = name;
            MaxHP = hp;
            HP = hp;
            Strength = strength;
            IsDead = false;
            IsFire = false;
        }

        public List<IAbility> Abilities
        {
            get
            {
                return abilities;
            }

            set
            {
                abilities = value;
            }
        }

        public List<IAbility> EffectsList
        {
            get
            {
                return effectsList;
            }

            set
            {
                effectsList = value;
            }
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

        public virtual Player Opponent
        {
            get
            {
                return opponent;
            }

            set
            {
                opponent = value;
            }
        }

        public bool IsDead { get; set; }

        public bool IsFire { get; set; }

        public int HP { get; protected set; }

        protected int MaxHP { get; set; }

        public virtual void MakeMove()
        {
            isSkip = false;
            List<IAbility> effects = effectsList;
            foreach (var effect in effectsList.ToList())
            {
                if (effect.SkippingMove)
                {
                    isSkip = true;
                    Logger.WriteLog($"{ToString()} is skipping step");
                }

                if (effect.IsFire)
                {
                    IsFire = true;
                    Logger.WriteLog($"{ToString()} is burning");
                }

                if (IsFire)
                {
                    HP -= 2;
                }

                HP -= (int)effect.Damage;

                if (HP <= 0)
                {
                    IsDead = true;
                    return;
                }

                if (HP <= 0)
                {
                    IsDead = true;
                    return;
                }

                effect.Duration -= 1;

                if (effect.Duration <= 0)
                {
                    effectsList.Remove(effect);
                }

                if (effectsList.Count <= 1)
                {
                    break;
                }
            }

            Logger.WriteLog($"{ToString()} has {HP} HP");
            Logger.WriteLog("-------------------------------------------------------");

            if (!isSkip)
            {
                DealDamage();
            }
        }

        public virtual void DealDamage()
        {
            int index = Random.Shared.Next(0, abilities.Count);
            opponent.Addeffect(abilities[index]);
            Logger.WriteLog($"{this.ToString()} applies {abilities[index].Name} and inflicts {(int)abilities[index].Damage}");
            abilities[index].UsageLimit -= 1;
            if (abilities[index].UsageLimit == 0)
            {
                Logger.WriteLog($"{ToString()} used maximum times of {abilities[index].Name}");
                abilities.RemoveAt(index);
            }
        }

        public abstract void Addeffect(IAbility effect);

        public virtual void SetDefaultValues()
        {
            HP = MaxHP;
            IsDead = false;
            IsFire = false;
            AddAbilities();
        }

        protected virtual void AddAbilities()
        {
            abilities.Clear();
            effectsList.Clear();
            abilities.Add(new Hit(Strength));
            abilities.Add(new Spellbinding());
        }
    }
}