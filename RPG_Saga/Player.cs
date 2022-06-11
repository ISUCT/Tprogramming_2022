namespace RpgSaga
{
    public abstract class Player
    {
        protected List<Ability> abilities;
        public Ability ActiveAbility { get; set; }
        public int GotDamage { get; protected set; }
        public string PlayerClass { get; protected set;}
        public int Health { get; protected set;}
        public int Strength { get; protected set; }
        public bool IsBurning { get; private set; }
        public bool IsBlind { get; private set; }

        public string Name { get; }

        public Player(int health, int strength, string name, Ability ability)
        {
            GotDamage = 0;
            abilities = new List<Ability>{ ability };
            ActiveAbility = abilities[0];
            PlayerClass = "Игрок без класса";
            Health = health;
            Strength = strength;
            Name = name;
            IsBurning = false;
            IsBlind = false;
        }

        public virtual void Attack(Player enemy, int damage)
        {
            if (IsBlind)
            {
                enemy.GetDamage(0);
                IsBlind = false;
                return;
            }

            enemy.GetDamage(damage);
        }

        public virtual void GetDamage(int damage)
        {
            GotDamage = damage;
            if (IsBurning)
            {
                Health -= 2;
            }
            
            Health -= GotDamage;
        }

        public void Burn()
        {
            IsBurning = true;
        }

        public void Blind()
        {
            IsBlind = true;
        }

        public virtual bool IsAlive()
        {
            if (Health <= 0)
            {
                return false;
            }
            
            return true;
        }

        public virtual void Refresh()
        {
            IsBurning = false;
            IsBlind = false;
        }
    } 
}
