namespace RPGSaga
{
    using RPGSaga.Heroes;

    public class Fight
    {
        private Player _player_1;
        private Player _player_2;

        public Fight(Player player_1, Player player_2)
        {
            _player_1 = player_1;
            _player_2 = player_2;
        }

        public void SetOpponent()
        {
            _player_1.Opponent = _player_2;
            _player_2.Opponent = _player_1;
        }

        public void StartFight()
        {
            Logger.WriteLog($"{_player_1.Name}, {_player_1.HP}, {_player_1.Strength} VS {_player_2.Name}, {_player_2.HP}, {_player_2.Strength}");
            while (!_player_1.IsDead && !_player_2.IsDead)
            {
                _player_1.MakeMove();
                Logger.WriteLog($"name: {_player_1.Name}, hp: {_player_1.HP}, strength: {_player_1.Strength}");

                _player_2.MakeMove();
                Logger.WriteLog($"name: {_player_2.Name}, hp: {_player_2.HP}, strength: {_player_2.Strength}");

                if (_player_1.IsDead)
                {
                    Logger.WriteLog($"Победил {_player_2.Name}");
                }
                
                if (_player_2.IsDead)
                {
                    Logger.WriteLog($"Победил {_player_1.Name}");
                }
            }
        }
    }
   
}
