namespace RpgSaga
{
    public class BattleLogger : ILogger
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
            Console.WriteLine($"({player.PlayerClass}) {player.Name} наносит {enemy.GotDamage} единиц урона противнику {enemy.Name} ({enemy.PlayerClass})");

            if (enemy.IsBurning)
            {
                System.Console.WriteLine($"{enemy.Name} горит и получает 2 единицы урона");
            }
        }

        public void Dead(Player player)
        {
            System.Console.WriteLine($"{player.Name} сдох");
        }
    }
}
