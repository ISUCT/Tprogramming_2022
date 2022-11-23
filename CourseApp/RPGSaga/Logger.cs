namespace CourseApp.RPGSaga
{
    using System;

    public static class Logger
    {
        public static void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }

        public static void Space()
        {
            Console.WriteLine();
        }
    }
}
