namespace CourseApp
{
    namespace Players
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using Abilities;
        using Effects;
        public class Knight : IPlayer
        {
            public string Name { get; set; }
            public int Strength { get; set; }
            public int Health { get; set; }
            public List <IAbility> Abilities { get; set; } = new List<IAbility>();
            public int CurrentAbility { get; set; }
            public List <IEffect> MyEffects { get; set; } = new List<IEffect>();
            public IEffect NormalState { get; set; }
            public string ClassName { get; set; }

            public Knight(string name, int strength, int health, string className)
            {
                Name = name;
                Strength = strength;
                Health = health;

                ClassName = className;

                Abilities.Add(new VengeanceStrike());
                if (ClassName == "Воин")
                {
                    Abilities.Add(new StunStrike());
                }
                NormalState = new Normal(Strength, Health);
            }

            public void TakingDamage(int damage)
            {
                Health -= damage;
            }

            public void AttackEnemy(IPlayer enemy)
            {
                enemy.TakingDamage(Strength);
            }

            public void EnterCurrentAbility()
            {
                Random random = new Random();
                CurrentAbility = random.Next(0, Abilities.Count);
            }

            public bool CanUltimate()
            {
                return Abilities[CurrentAbility].CanSpell();
            }

            public int Ultimate(IPlayer myself, IPlayer enemy, int round)
            {
                Abilities[CurrentAbility].Spell(myself, enemy, round);
                return CurrentAbility;
            }

            public void Effect(IPlayer myself)
            {
                if (MyEffects.Count != 0)
                {
                    foreach (var effect in MyEffects)
                    {
                        effect.State(myself);
                    }
                }
            }

            public void DeleteEffect(IPlayer myself, int round, int numberPlayer)
            {
                if (MyEffects.Count != 0)
                {
                    foreach (var effect in MyEffects.ToList())
                    {
                        effect.DeleteState(myself, round, numberPlayer);
                    }
                }
            }

            public void RestoreAfterBattle()
            {
                if (NormalState is Normal normal)
                {
                    Health = normal.Health;
                    Strength = normal.Strength;
                }

                foreach (var ability in Abilities)
                {
                    ability.NumberUses = 0;
                }

                MyEffects.Clear();
            }
        }
    }
}

