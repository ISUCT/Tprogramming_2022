namespace CourseApp.Base
{
    using CourseApp.Logger;

    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game(new GameLogger());
            game.Run();
        }
    }
}