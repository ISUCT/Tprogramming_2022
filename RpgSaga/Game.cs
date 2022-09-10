namespace RpgSaga
{
    public class Game
    {
        private int _numberOfPlayers;
        private List<Player> _players;
        private PlayerSystem _playerSystem;
        private BattleSystem _battleSystem;
        public Game()
        {
            _playerSystem = new PlayerSystem(new PlayerLogger());
            _numberOfPlayers = _playerSystem.EnterNumberOfPlayers();
            _players = new List<Player>(_numberOfPlayers);

            for (int i = 0; i < _players.Capacity; i++)
            {
                _players.Add(_playerSystem.CreatePlayer(i));
            }

            _battleSystem = new BattleSystem(new BattleLogger());
        }

        public void Run()
        {
            _battleSystem.Battle(_players);
        }
    } 
}
