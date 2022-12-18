namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public abstract class Player
    {
        private bool enchantedDust;

        private bool loveArrow;

        public Player(int health, int inputS, string name, string ability)
        {
            MaxH = health;
            NowH = health;
            Strength = inputS;
            Name = name;
            AbilityName = ability;
            AbilityLeft = 1;
            enchantedDust = false;
            loveArrow = false;
        }

        public float MaxH { get; protected set; }

        public float NowH { get; protected set; }

        public float Strength { get; protected set; }

        public string Name { get; protected set; }

        public int AbilityLeft { get; protected set; }

        public string AbilityName { get; protected set; }

        public abstract string Ability();

        public float Attack()
        {
            return Strength;
        }

        public bool Damage(float damage)
        {
            NowH -= damage;
            return IsDeath();
        }

        public void Debaff(string debuffName)
        {
            if (debuffName == "Заколдованная пыль")
            {
                enchantedDust = true;
            }
            else if (debuffName == "Cтрелы любви")
            {
                loveArrow = true;
            }
        }

        public string DebaffInfo()
        {
            if (enchantedDust)
            {
                enchantedDust = false;
                return "Заколдованная пыль";
            }
            else if (loveArrow)
            {
                Damage(2);
                return "Cтрелы любви";
            }

            return string.Empty;
        }

        public bool IsDeath()
        {
            if (NowH <= 0)
            {
                return true;
            }

            return false;
        }

        public void Update()
        {
            AbilityLeft = 1;
            NowH = MaxH;
            loveArrow = false;
            enchantedDust = false;
        }
    }
}