namespace RpgSaga
{
    public abstract class Player : IComparable
    {
        protected List<Ability> abilities;

        public Ability ActiveAbility { get; set; }
        public PlayerConditions playerConditions;
        public int GotDamage { get; protected set; }
        public string PlayerClass { get; protected set;}
        public int Health { get; protected set;}
        public int Strength { get; protected set; }
        public string Name { get; }

        public Player(int health, int strength, string name, Ability ability)
        {
            playerConditions = new PlayerConditions();
            abilities = new List<Ability>{ ability };
            ActiveAbility = abilities[0];
            GotDamage = 0;
            Health = health;
            Strength = strength;
            Name = name;
            PlayerClass = "Игрок без класса";
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Player player = (Player) obj;

            if (player == null)
            {
                throw new ArgumentException("Object is not a Player!");
            }

            return this.Health.CompareTo(player.Health);
        }

        public virtual void Attack(Player enemy, int damage)
        {
            if (playerConditions.Condition[Conditions.IsBlind])
            {
                enemy.GetDamage(0);
                Unblind();
                return;
            }

            enemy.GetDamage(damage);
        }

        public virtual void GetDamage(int damage)
        {
            GotDamage = damage;
            if (playerConditions.Condition[Conditions.IsBurning])
            {
                Health -= 2;
            }
            
            Health -= GotDamage;
        }

        public void Burn()
        {
            playerConditions.Condition[Conditions.IsBurning] = true;
            GetDamage(0);
        }

        public void Blind()
        {
            playerConditions.Condition[Conditions.IsBlind] = true;
            GetDamage(0);
        }

        public void Unblind()
        {
            playerConditions.Condition[Conditions.IsBlind] = false;
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
            playerConditions.Condition[Conditions.IsBurning] = false;
            playerConditions.Condition[Conditions.IsBlind] = false;
            GotDamage = 0;
        }
    } 
}
