namespace CourseApp.RPGSaga
{
    public class Game
    {
        public static void Start(int count)
        {
            var gameBuilder = new BattlesBuilder(count);
            gameBuilder.StartTournament();
            gameBuilder.GetWinner();
        }
    }
}