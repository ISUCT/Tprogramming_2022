namespace RpgSaga
{
    public class Logger
    {
        public void ShowRound(int round)
        {
            System.Console.WriteLine("Кон " + round + ".");
            System.Console.WriteLine();
        }

        public void SeparateBattle()
        {
            System.Console.WriteLine();
        }

        public void UsesAbility(Player player, Player enemy)
        {
            Console.WriteLine($"({player.PlayerClass}) {player.Name} использует способность {player.ActiveAbility.AbilityName} и наносит {enemy.GotDamage} единиц урона противнику {enemy.Name} ({enemy.PlayerClass})");
            
            if (enemy.IsBurning)
            {
                System.Console.WriteLine($"{enemy.Name} горит и получает 2 единицы урона");
            }
        }

        public void Attack(Player player, Player enemy)
        {
            Console.WriteLine($"({player.PlayerClass}) {player.Name} атакует и наносит {enemy.GotDamage} единиц урона противнику {enemy.Name} ({enemy.PlayerClass})");
            
            if (enemy.IsBurning)
            {
                System.Console.WriteLine($"{enemy.Name} горит и получает 2 единицы урона");
            }
        }

        public void Burning(Player player)
        {
            System.Console.WriteLine($"{player.Name} горит и получает 2 единицы урона");
        }

        public void ShowName(string name)
        {
            System.Console.WriteLine(name);
        }

        public void EnterTheNumber()
        {
            Console.WriteLine("Enter the even number of players");
        }

        public void NumberIsEven()
        {
            Console.WriteLine("Enter the even number of players");
        }

        public void Dead(Player player)
        {
            System.Console.WriteLine($"{player.Name} сдох");
        }
    } 
}
