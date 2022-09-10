namespace RpgSaga
{
    public class PlayerSystem
    {
        public enum Classes
        {
            Archer,
            Kickboxer,
            Dazzler
        }

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
            Classes playerClass = (Classes) (number / 3);
            var rand = new Random();
            int health = rand.Next(50, 150);
            int strength = rand.Next(25, 50);
            string name = Constants.Names[number % Constants.Names.Length];
            
            _playerLogger.ShowName(name);

            switch (playerClass) {
                case Classes.Archer:
                    return new Archer(health, strength, name, new FireArrows());
                case Classes.Kickboxer:
                    return new Kickboxer(health, strength, name, new KickBoxing());
                default:
                    return new Dazzler(health, strength, name, new Blinding());
            }
        }
    }
}
