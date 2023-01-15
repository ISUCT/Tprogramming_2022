namespace CourseApp
{
    public class Logger : ILogger
    {
        public void Log(string str)
        {
            System.Console.WriteLine(str);
        }
    }
}