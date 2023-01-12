namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public abstract class Player
    {
        private string debaffs;

        public Player(int maxHealth, int strength, string name, string abilityName, int maxAbilityUsages)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
            this.Strength = strength;
            this.Name = name;
            this.AbilityName = abilityName;
            this.MaxAbilityUsages = maxAbilityUsages;
        }

        public float MaxHealth { get; protected set; }

        public float CurrentHealth { get; protected set; }

        public float Strength { get; protected set; }

        public string Name { get; protected set; }

        public int MaxAbilityUsages { get; protected set; }

        public int AbilityLeft { get; protected set; }

        public string AbilityName { get; protected set; }

        public abstract Tuple<string, float> Ability();

        public Tuple<string, float> Attack()
        {
            return Tuple.Create("наносит урон", Strength);
        }

        public bool GetDamage(float damage)
        {
            CurrentHealth -= damage;
            return CheckDeath();
        }

        public void SetDebaff(string debuffName)
        {
            debaffs = debuffName;
        }

        public Tuple<string, float> CheckStatus()
        {
            switch (debaffs)
                {
                    case "Огненная стрела":
                        return Tuple.Create("Огненная стрела", 2.0f);
                    case "Заворожение":
                        debaffs = string.Empty;
                        return Tuple.Create("Заворожение", .0f);
                    default:
                        return Tuple.Create(" ", .0f);
                }
        }

        public bool CheckDeath()
        {
            if (CurrentHealth <= 0)
            {
                return true;
            }

            return false;
        }

        public void Update()
        {
            AbilityLeft = MaxAbilityUsages;
            CurrentHealth = MaxHealth;
            debaffs = string.Empty;
        }
    }
}