namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BattleMaker
    {
        public static Player Battle(Player player1, Player player2)
        {
            player1.health = player1.Maxhealth;
            player2.health = player2.Maxhealth;
            var winner = player1;
            while (player1.health > 0 && player2.health > 0)
            {
                player1.DealDamage();
                player2.health = player2.health - player1.Power;
                if (player2.health <= 0)
                {
                    winner = player1;
                    Console.WriteLine($"Игрок {player1} победил!");
                    return winner;
                }
                player2.DealDamage();
                player1.health = player1.health - player2.Power;
                if (player2.health <= 0)
                {
                    winner = player2;
                    Console.WriteLine($"Игрок {player2} победил!");
                    return winner;
                }
            }
        return winner;
        }
    }
}