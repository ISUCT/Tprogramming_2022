namespace CourseApp.RpgSaga;

using System;
using System.Collections.Generic;
using CourseApp.RpgSaga.Players;
using CourseApp.RpgSaga.States;

public class Fight
{
    public Fight(Player firstPlayer, Player secondPlayer, ref List<Player> allPlayers, Logger logger)
    {
        FirstPlayer = firstPlayer;
        SecondPlayer = secondPlayer;
        AllPlayers = allPlayers;
        Log = logger;
    }

    private Logger Log { get; set; }

    private Player FirstPlayer { get; set; }

    private Player SecondPlayer { get; set; }

    private int Round { get; set; } = 1;

    private List<Player> AllPlayers { get; set; }

    public void Battle()
    {
        bool stopGame;

        Log.PrintVersus(FirstPlayer, SecondPlayer);

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

    private bool PlayerTurn(Player playerGame, Player playerWait, int numberPlayer)
    {
        Random rand = new Random();
        bool stopGame = false;
        bool isStun = false;

        playerGame.DeleteState(playerGame, Round, numberPlayer);
        playerGame.State(playerGame);
        Log.PrintEffect(playerGame);

        if (IsDefeat(playerGame, playerWait))
        {
            stopGame = true;
            return stopGame;
        }

        foreach (var effect in playerGame.MyStates)
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
                Log.PrintAttack(playerGame, playerWait);
            }
            else
            {
                if (playerGame.CanUltimate())
                {
                    playerGame.Ultimate(playerGame, playerWait, Round);
                    Log.PrintUltimate(playerGame, playerWait);
                }
                else
                {
                    playerGame.AttackEnemy(playerWait);
                    Log.PrintAttack(playerGame, playerWait);
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

    private bool IsDefeat(Player loser, Player winner)
    {
        if (loser.Health <= 0)
        {
            Log.PrintDefeat(loser);
            AllPlayers.Remove(loser);
            winner.RestoreAfterBattle();
            return true;
        }

        return false;
    }
}
