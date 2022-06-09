namespace RpgSaga
{
    public class BattleSystem
    {
        private bool _battleFinished;
        private Logger _battleLogger;
        public BattleSystem(Logger logger)
        {
            _battleFinished = false;
            _battleLogger = logger;
        }

        public void Battle(List<Player> _players)
        {
            for (int i = 1; !_battleFinished; )
            {
                MakeStep(_players[i - 1], _players[i]);
                MakeStep(_players[i], _players[i - 1]);

                if (!_players[i].IsAlive())
                {
                    _battleLogger.Dead(_players[i]);
                    _players.Remove(_players[i]);
                    _battleFinished = true;
                }

                if (!_players[i - 1].IsAlive())
                {
                    _battleLogger.Dead(_players[i - 1]);
                    _players.Remove(_players[i - 1]);
                    _battleFinished = true;
                }
            }
        }

        public void MakeStep(Player player, Player enemy)
        {
            if (player.IsAlive())
            {
                var rand = new Random();
                if (rand.Next(0, 2) == 0 && player.CanUseAbility)
                {
                    player.UseAbility(enemy);
                    return;
                }

                _battleLogger.Attack(player, enemy);
                player.Attack(enemy);
            }
        }
    }
}