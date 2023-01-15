namespace CourseApp
{
    using System.Collections.Generic;

    public class Entity
    {
        private List<Ability> abilities;
        private List<Ability> effects;

        public Entity(int health, int damage, string name, Ability ability)
        {
            abilities = new List<Ability>
            {
                new Attack(damage),
                ability,
            };
            effects = new List<Ability>();
            ActiveAbility = abilities[0];
            Health = health;
            Damage = damage;
            Name = name;
            CanAttack = true;
        }

        public int Health { get; private set; }

        public int Damage { get; private set; }

        public string Name { get; }

        public bool CanAttack { get; protected set; }

        public Ability ActiveAbility { get; private set; }

        public Ability MakeStep()
        {
            if (Health <= 0 || !CanAttack)
            {
                CanAttack = true;
                ActiveAbility = new StepSkip();
                return ActiveAbility.UseAbility();
            }

            System.Random random = new System.Random();
            int abilityIndex = random.Next(abilities.Count);
            ActiveAbility = abilities[abilityIndex];
            if (!ActiveAbility.CanUse)
            {
                ActiveAbility = abilities[0];
            }

            return ActiveAbility.UseAbility();
        }

        public int CheckState()
        {
            int totalDamage = 0;
            foreach (var e in effects)
            {
                totalDamage += e.Damage;
                if (e.Type == AbilityTypes.Blind)
                {
                    CanAttack = false;
                }

                e.StepsDuration--;
            }

            Health -= totalDamage;
            effects.RemoveAll(e => e.StepsDuration <= 0);
            return totalDamage;
        }

        public void Refresh()
        {
            foreach (var a in abilities)
            {
                a.CanUse = true;
            }

            CanAttack = true;
            effects = new List<Ability>();
        }

        public void AddEffect(Ability ability)
        {
            effects.Add(ability);
        }
    }
}