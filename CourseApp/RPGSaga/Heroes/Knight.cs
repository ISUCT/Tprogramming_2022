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
        private bool isSkip;
        private Player opponent;
        private List<IAbility> abilities;
        private List<IAbility> effectsList;

        public Knight(string name, int hp, int strength)
        : base(name, hp, strength)
        {
            abilities = new List<IAbility>() { new Hit(strength), new VengeanceStrike(strength) };
            effectsList = new List<IAbility>();
        }

        public override Player Opponent
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

        public override void MakeMove()
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

        public override void Addeffect(IAbility effect)
        {
            effectsList.Add(effect);
        }

        public void SetOppnent(Player eOpponent)
        {
            opponent = eOpponent;
        }

        public override void DealDamage()
        {
            int index = Random.Shared.Next(0, abilities.Count);
            opponent.Addeffect(abilities[index]);
            Logger.WriteLog($"{this.ToString()} применяет {abilities[index].Name} и наносит {(int)abilities[index].Damage}");
            abilities[index].UsageLimit -= 1;
            if (abilities[index].UsageLimit == 0)
            {
                Logger.WriteLog($"{ToString()} used maximum times of {abilities[index].Name}");
                abilities.RemoveAt(index);
            }
        }

        public override void SetDefaultValues()
        {
            HP = 95;
            IsDead = false;
            IsFire = false;
            AddAbilities();
        }

        public override string ToString()
        {
            return $"Knight: ({Name})";
        }

        protected void AddAbilities()
        {
            abilities.Clear();
            effectsList.Clear();
            abilities.Add(new Hit(Strength));
            abilities.Add(new VengeanceStrike(Strength));
        }
    }
}