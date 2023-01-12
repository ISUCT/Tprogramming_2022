namespace CourseApp;
using RpgSaga;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();
        Game game = new Game(logger);
        game.Run();
    }
}
