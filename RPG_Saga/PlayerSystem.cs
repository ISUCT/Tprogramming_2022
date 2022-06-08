namespace RpgSaga
{
    public class PlayerSystem
    {
        public int EnterNumberOfPlayers()
        {
            Console.WriteLine("Enter the even number of players");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0 && number > 0)
                {
                    return number;
                }
            }
            
            Console.WriteLine("The number of players must be even integer");
            return 0;
        }

        public Player CreatePlayer(int number)
        {
            var rand = new Random();
            int health = rand.Next(50, 150);
            int strength = rand.Next(25, 50);
            string name = Constants.Names[number % Constants.Names.Length];
            if (number % 3 == 0)
            {
                return new Baranka(health, strength, name);
            }
            if (number % 3 == 1)
            {
                return new ChupaChups(health, strength, name);
            }

            return new Wheelchair(health, strength, name);
        }
    }
}
