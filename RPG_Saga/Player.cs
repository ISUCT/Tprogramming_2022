namespace RpgSaga
{
    public abstract class Player : Ability
    {
        public abstract string AbilityName { get; set; }
        public bool CanUseAbility { get; protected set; }
        public bool IsBurning { get; private set; }
        public string PlayerClass { get; protected set;}
        public int Health { get; set;}
        public int Strength { get; protected set; }
        public string Name { get; }

        public Player(int health, int strength, string name)
        {
            PlayerClass = "Игрок без класса";
            Health = health;
            Strength = strength;
            Name = name;
            IsBurning = false;
            CanUseAbility = true;
        }

        public virtual int Attack(Player enemy)
        {
            enemy.GetDamage(Strength);
            return Strength;
        }

        public virtual void UseAbility(Player enemy) {}

        public void GetDamage(int damage)
        {
            if (IsBurning)
            {
                System.Console.WriteLine($"{Name} горит и получает 2 единицы урона");
                Health -= 2;
            }
            
            Health -= damage;
        }

        public void Burn()
        {
            IsBurning = true;
            GetDamage(0);
        }

        public bool IsAlive()
        {
            if (Health <= 0)
            {
                return false;
            }
            
            return true;
        }
    } 
}
