namespace RpgSaga
{
    public class BattleSystem
    {
        bool _battleFinished;

        public BattleSystem()
        {
            _battleFinished = false;
        }

        public void Battle(List<Player> _players)
        {
            for (int i = 1; !_battleFinished; )
            {
                _players[i - 1].MakeStep(_players[i]);
                _players[i].MakeStep(_players[i - 1]);

                if (!_players[i].IsAlive())
                {
                    System.Console.WriteLine($"{_players[i].Name} сдох");
                    _players.Remove(_players[i]);
                    _battleFinished = true;
                }

                if (!_players[i - 1].IsAlive())
                {
                    System.Console.WriteLine($"{_players[i - 1].Name} сдох");
                    _players.Remove(_players[i - 1]);
                    _battleFinished = true;
                }
            }
        }
    }
}