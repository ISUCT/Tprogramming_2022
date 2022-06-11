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

        public void Battle(List<Player> players)
        {
            for (int round = 1; players.Count > 1; round++)
            {
                _battleLogger.ShowRound(round);
                for (int i = 1; i < players.Count ; i++)
                {
                    Duel(players[i - 1], players[i]);
                    _battleLogger.SeparateBattle();

                    var defeatedPlayer = FreeList(players[i - 1], players[i]);
                    players.Remove(defeatedPlayer);
                }

                RefreshPlayers(players);
            }
        }

        private Player FreeList(Player player1, Player player2)
        {
            if (!player1.IsAlive())
            {
                return player1;
            }

            return player2;
        }

        private void Duel(Player player1, Player player2)
        {
            for ( ; !_battleFinished; )
            {
                MakeStepBoth(player1, player2); 
            }

            _battleFinished = false;
        }

        private void MakeStepBoth(Player player1, Player player2)
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

        private void MakeStepOne(Player player, Player enemy)
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

        private bool CheckAlive(Player player)
        {
            if (!player.IsAlive())
            {
                _battleLogger.Dead(player);
                return false;
            }

            return true;
        }

        private void RefreshPlayers(List<Player> playerList)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                playerList[i].Refresh();
            }
        }
    }
}
