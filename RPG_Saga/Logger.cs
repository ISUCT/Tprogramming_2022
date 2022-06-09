namespace RpgSaga
{
    public class Logger
    {
        public void KickBoxing(Player player, Player enemy)
        {
            Console.WriteLine($"({player.PlayerClass}) {player.Name} атакует и наносит {player.Strength} единиц урона противнику {enemy.Name} ({enemy.PlayerClass})");
        }

        public void Attack(Player player, Player enemy)
        {
            Console.WriteLine($"({player.PlayerClass}) {player.Name} атакует и наносит {player.Strength} единиц урона противнику {enemy.Name} ({enemy.PlayerClass})");
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
