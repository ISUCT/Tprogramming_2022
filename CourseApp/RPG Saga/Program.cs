namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int players = 0;
            Game start = new Game();
            players = start.StartTheTournament(players);
            Arena arena = new Arena();
            arena.Lap(players);
            Console.ReadLine();
        }
    }
}