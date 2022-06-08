namespace RpgSaga
{
    public abstract class Player : Ability
    {
        private bool _isBurning;
        public string PlayerClass { get; protected set;}
        public int Health { get; private set;}
        public int Strength { get; private set; }
        public string Name { get; }
        public Player(int health, int strength, string name)
        {
            PlayerClass = "Игрок без класса";
            Health = health;
            Strength = strength;
            Name = name;
            _isBurning = false;
        }

        public virtual void MakeStep(Player enemy)
        {
            if (IsAlive())
            {
                var rand = new Random();
                if (rand.Next(0, 2) == 0)
                {
                    Attack(enemy);
                    return;
                }

                UseAbility(enemy);
            }
        }

        public virtual void Attack(Player enemy)
        {
            Console.WriteLine($"({PlayerClass}) {Name} атакует и наносит {Strength} единиц урона противнику {enemy.Name} ({enemy.PlayerClass})");
            enemy.GetDamage(Strength);
        }

        public virtual void UseAbility(Player enemy) {}

        public void GetDamage(int damage)
        {
            if (_isBurning)
            {
                System.Console.WriteLine($"{Name} горит и получает 2 единицы урона");
                Health -= 2;
            }
            
            Health -= damage;
        }

        public void Burn()
        {
            _isBurning = true;
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
