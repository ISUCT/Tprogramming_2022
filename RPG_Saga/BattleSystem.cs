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
            for (int i = 0; i < _players.Count ; i++)
            {
                Duel(_players[i], _players[i + 1]);
                
                var defeatedPlayer = FreeList(_players[i], _players[i + 1]);
                _players.Remove(defeatedPlayer);
            }
        }

        public Player FreeList(Player player1, Player player2)
        {
            if (!player1.IsAlive())
            {
                return player1;
            }

            return player2;
        }

        public void Duel(Player player1, Player player2)
        {
            for ( ; !_battleFinished; )
            {
                MakeStepBoth(player1, player2); 
            }

            _battleFinished = false;
        }

        public void MakeStepBoth(Player player1, Player player2)
        {
            if (!CheckAlive(player1))
            {
                _battleFinished = true;
                return;
            }

            MakeStepOne(player1, player2);
            
            if (!CheckAlive(player2))
            {
                _battleFinished = true;
                return;
            }

            MakeStepOne(player2, player1);
        }

        public void MakeStepOne(Player player, Player enemy)
        {
            var rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0 && player.ActiveAbility.CanUseAbility)
            {
                player.ActiveAbility.UseAbility(player, enemy);
                _battleLogger.UsesAbility(player, enemy);
                return;
            }

            player.Attack(enemy, player.Strength);
            _battleLogger.Attack(player, enemy);
        }

        public bool CheckAlive(Player player)
        {
            if (!player.IsAlive())
            {
                _battleLogger.Dead(player);
                return false;
            }

            return true;
        }
    }
}
