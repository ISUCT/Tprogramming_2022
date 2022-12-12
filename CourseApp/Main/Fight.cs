namespace CourseApp.Fight
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Effects;
    using CourseApp.Logger;
    using CourseApp.Players;

    public class Fight
    {
        public Fight(IPlayer firstPlayer, IPlayer secondPlayer, ref List<IPlayer> allPlayers, ILogger logger)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
            AllPlayers = allPlayers;
            Logger = logger;
        }

        private ILogger Logger { get; set; }

        private IPlayer FirstPlayer { get; set; }

        private IPlayer SecondPlayer { get; set; }

        private int Round { get; set; } = 1;

        private List<IPlayer> AllPlayers { get; set; }

        public void Battle()
        {
            bool stopGame;

            Logger.PrintVersus(FirstPlayer, SecondPlayer);

            while (true)
            {
                stopGame = PlayerTurn(FirstPlayer, SecondPlayer, 1);

                if (stopGame)
                {
                    break;
                }

                stopGame = PlayerTurn(SecondPlayer, FirstPlayer, 2);

                if (stopGame)
                {
                    break;
                }

                Round++;
            }
        }

        private bool PlayerTurn(IPlayer playerGame, IPlayer playerWait, int numberPlayer)
        {
            Random rand = new Random();
            bool stopGame = false;
            bool isStun = false;

            playerGame.DeleteEffect(playerGame, Round, numberPlayer);
            playerGame.Effect(playerGame);
            Logger.PrintEffect(playerGame);

            if (IsDefeat(playerGame, playerWait))
            {
                stopGame = true;
                return stopGame;
            }

            foreach (var effect in playerGame.MyEffects)
            {
                if (effect is Stun)
                {
                    isStun = true;
                }
            }

            if (!isStun)
            {
                if (rand.Next(0, 3) > 0)
                {
                    playerGame.AttackEnemy(playerWait);
                    Logger.PrintAttack(playerGame, playerWait);
                }
                else
                {
                    playerGame.EnterCurrentAbility();
                    if (playerGame.CanUltimate())
                    {
                        int randomUlt = playerGame.Ultimate(playerGame, playerWait, Round);
                        Logger.PrintUltimate(playerGame, playerWait, randomUlt);
                    }
                    else
                    {
                        playerGame.AttackEnemy(playerWait);
                        Logger.PrintAttack(playerGame, playerWait);
                    }
                }
            }

            if (IsDefeat(playerWait, playerGame))
            {
                stopGame = true;
                return stopGame;
            }

            return stopGame;
        }

        private bool IsDefeat(IPlayer loser, IPlayer winner)
        {
            if (loser.Health <= 0)
            {
                Logger.PrintDefeat(loser);
                AllPlayers.Remove(loser);
                winner.RestoreAfterBattle();
                return true;
            }

            return false;
        }
    }
}
