namespace RpgSaga
{
    public class PlayerSystem
    {
        private PlayerLogger _playerLogger;

        public PlayerSystem(PlayerLogger logger)
        {
            _playerLogger = logger;
        }

        public int EnterNumberOfPlayers()
        {
            _playerLogger.EnterTheNumberOfPlayers();
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0 && number > 0)
                {
                    return number;
                }
            }
            
            _playerLogger.NumberIsEvenWarning();
            return 0;
        }

        public Player CreatePlayer(int number)
        {
            var rand = new Random();
            int health = rand.Next(50, 150);
            int strength = rand.Next(25, 50);
            string name = Constants.Names[number % Constants.Names.Length];
            
            _playerLogger.ShowName(name);

            if (number % 3 == 0)
            {
                return new Archer(health, strength, name, new FireArrows());
            }
            if (number % 3 == 1)
            {
                return new Kickboxer(health, strength, name, new KickBoxing());
            }

            return new Dazzler(health, strength, name, new Blinding());
        }
    }
}
