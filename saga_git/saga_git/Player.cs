namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public abstract class Player
    {
        private string debaff;

        public Player(int maxHealth, int strength, string name, string abilityName, int maxAbilityUsages)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
            this.Strength = strength;
            this.Name = name;
            this.AbilityName = abilityName;
            this.MaxAbilityUsages = maxAbilityUsages;
            this.AbilityLeft = maxAbilityUsages;
        }

        public float MaxHealth { get; protected set; }

        public float CurrentHealth { get; protected set; }

        public float Strength { get; protected set; }

        public string Name { get; protected set; }

        public int MaxAbilityUsages { get; protected set; }

        public int AbilityLeft { get; protected set; }

        public string AbilityName { get; protected set; }

        public bool CheckAbility() // проверка на возможность применения способности
        {
            if (AbilityLeft > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual string Ability() // применение способности
        {
            AbilityLeft--;
            return AbilityName;
        }

        public virtual float Attack() // атака
        {
            return Strength;
        }

        public void GetDamage(float damage) // получение урона
        {
            CurrentHealth -= damage;
        }

        public void SetDebaff(string dName) // установка дебаффов
        {
            debaff = dName;
        }

        public string DebaffStatus() // проверка действующих дебаффов
        {
            string buffer = debaff;
            switch (debaff)
            {
                case "Огненная стрела":
                    break;
                case "Заворожение":
                    debaff = string.Empty;
                    break;
            }

            return buffer;
        }

        public bool CheckDeath() // проверка на смерть
        {
            if (CurrentHealth <= 0)
            {
                return true;
            }

            return false;
        }

        public void Refresh() // востановление показателей
        {
            AbilityLeft = MaxAbilityUsages;
            CurrentHealth = MaxHealth;
            debaff = string.Empty;
        }
    }
}
