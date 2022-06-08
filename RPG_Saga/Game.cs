namespace RpgSaga
{
    public class Game
    {
        private int _numberOfPlayers;
        private List<Player> _players;
        PlayerSystem playerSystem = new PlayerSystem();

        public void Run()
        {
            while (_players.Count > 1)
            {
                System.Console.WriteLine("Hi!");
            }
        }

        public void Init()
        {
            _numberOfPlayers = playerSystem.EnterNumberOfPlayers();
            _players = new List<Player>(_numberOfPlayers);
            for (int i = 0; i < _players.Capacity; i++)
            {
                _players.Add(playerSystem.CreatePlayer(i));
            }
        }
    } 
}
