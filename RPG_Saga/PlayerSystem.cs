namespace RpgSaga
{
    public class PlayerSystem
    {
        private Logger _playerLog;

        public PlayerSystem(Logger logger)
        {
            _playerLog = logger;
        }

        public int EnterNumberOfPlayers()
        {
            _playerLog.EnterTheNumber();
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0 && number > 0)
                {
                    return number;
                }
            }
            
            _playerLog.NumberIsEven();
            return 0;
        }

        public Player CreatePlayer(int number)
        {
            var rand = new Random();
            int health = rand.Next(50, 150);
            int strength = rand.Next(25, 50);
            string name = Constants.Names[number % Constants.Names.Length];
            
            _playerLog.ShowName(name);

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
