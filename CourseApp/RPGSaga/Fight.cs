namespace CourseApp.RPGSaga
{
    using CourseApp.RPGSaga.Heroes;

    public class Fight
    {
        private Player player1;
        private Player player2;
        private Player loser;
        private Player winner;

        public Fight(Player firstPlayer, Player secondPlayer)
        {
            player1 = firstPlayer;
            player2 = secondPlayer;
        }

        public void SetOpponent()
        {
            player1.Opponent = player2;
            player2.Opponent = player1;
        }

        public Player StartFight()
        {
            Logger.WriteLog("Характеристики:");
            Logger.WriteLog($"Name: ({player1.Name}), HP: {player1.HP}, Strength: {player1.Strength} VS Name: ({player2.Name}), HP: {player2.HP}, Strength: {player2.Strength}");
            while (!player1.IsDead && !player2.IsDead)
            {
                player1.MakeMove();
                player2.MakeMove();
            }

            if (player1.IsDead)
            {
                loser = player1;
                winner = player2;
            }
            else
            {
                loser = player2;
                winner = player1;
            }

            Logger.WriteLog($"Winer is {winner.Name}");

            return winner;
        }
    }
}
