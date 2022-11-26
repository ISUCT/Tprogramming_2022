namespace CourseApp
{
    using System;

    public abstract class Player : IPlayer
    {
        public Player(string name, double health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Inactive = 0;
            Impact = false;
            DefaultHealth = health;
        }

        public int Inactive { get; set; }

        public double DefaultHealth { get; set; }

        public string Name { get; set; }

        public string Class_player { get; set; }

        public bool Impact { get; set; }

        public string UltimateName { get; set; }

        public int UltimateDamage { get; set; }

        public int DamageInfo { get; set; }

        public double Health { get; set; }

        public int Strength { get; set; }

        
        public virtual int Ultimate(Player player, Player rival)
        {
            return 0;
        }

        public int AtTheAttack(Player host, Player warrior_rival)
        {
            if (host.Impact)
            {
                host.Impact = false;
                return DamageInfo = host.Ultimate(host, warrior_rival);
            }
            else
            {
                return DamageInfo = Strength;
            }
        }

        public int AtTheAttackRival(Player host, Player warrior_rival)
        {
            if (warrior_rival.Impact)
            {
                warrior_rival.Impact = false;
                return DamageInfo = warrior_rival.Ultimate(host, warrior_rival);
            }
            else
            {
                return DamageInfo = Strength;
            }
        }
        public virtual string InfoOutput()
        {
            return $"Имя: {Name} ; Здоровье: {Health} ; Сила: {Strength}";
        }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }

        public void ResetHealth()
        {
            Health = DefaultHealth;
        }
    }
}