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

            CheckConditions(enemy);
        }

        public void Attack(Player player, Player enemy)
        {
            Console.WriteLine($"({player.PlayerClass}) {player.Name} наносит {enemy.GotDamage} единиц урона противнику {enemy.Name} ({enemy.PlayerClass})");

            CheckConditions(enemy);
        }

        public void Dead(Player player)
        {
            System.Console.WriteLine($"{player.Name} трагично погиб в безжалостной схватке");
        }

        private void CheckConditions(Player player)
        {
            int conditionsCount = player.playerConditions.Condition.Count;
            var values = Enum.GetValues(typeof(Conditions));
            foreach (Conditions condition in values)
            {
                if (player.playerConditions.Condition[condition])
                {
                    System.Console.WriteLine($"({player.PlayerClass}) {player.Name} " + Constants.StringConditions[condition]);
                }
            }
        }
    }
}
