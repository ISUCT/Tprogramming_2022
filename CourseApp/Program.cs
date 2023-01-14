namespace CourseApp
{
    using System;
    using CourseApp.RPGSaga;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Generator;
    using CourseApp.RPGSaga.Heroes;

    public class Program
    {
        public static void Main(string[] args)
        {
            // var gameBuilder = new BattlesBuilder(10);
            // gameBuilder.StartTournament();
            // gameBuilder.GetWinner();
            Game.Start(10);
        }
    }
}
