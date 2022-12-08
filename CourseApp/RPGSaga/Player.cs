namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public abstract class Player
    {
        private List<string> debaffs;

        public Player(int maxHealth, int strength, string name, string abilityName, int maxAbilityUsages)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
            this.Strength = strength;
            this.Name = name;
            this.AbilityName = abilityName;
            this.MaxAbilityUsages = maxAbilityUsages;
            this.debaffs = new List<string>();
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
            CurrentHealth = (float)Math.Round(CurrentHealth - damage, 2);
            return CheckDeath();
        }

        public void SetDebaff(string debuffName)
        {
            debaffs.Add(debuffName);
        }

        public List<Tuple<string, float>> CheckStatus()
        {
            List<Tuple<string, float>> returnedList = new List<Tuple<string, float>>();
            string[] buffer = new string[debaffs.Count];
            debaffs.CopyTo(buffer);
            foreach (string debuffName in buffer)
            {
                switch (debuffName)
                {
                    case "Кровавый удар":
                        returnedList.Add(Tuple.Create("Кровавый удар", 2.0f));
                        if (GetDamage(2))
                        {
                            returnedList.Add(Tuple.Create("PlayerIsDied", 1.0f));
                            return returnedList;
                        }

                        break;
                    case "Удар щитом":
                        returnedList.Add(Tuple.Create("Удар щитом", .0f));
                        debaffs.RemoveAt(debaffs.IndexOf(debuffName));
                        break;
                }
            }

            return returnedList;
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
            debaffs.Clear();
        }
    }
}
