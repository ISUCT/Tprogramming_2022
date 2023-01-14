namespace RPGsagaApp
{
    using System;

    public class Logger
    {
        public void GameOver(Hero winner)
        {
            Console.WriteLine($"Победителем становится {winner}!");
        }
    }
}