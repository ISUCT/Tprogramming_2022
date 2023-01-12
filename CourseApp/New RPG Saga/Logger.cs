namespace CourseApp.RPG_Saga
{
    using System;

    public class Logger
    {
        public static void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }

        public static void NewRegistration(int numberOfRegistration)
        {
            Console.WriteLine();
            Console.WriteLine($"*********** {numberOfRegistration} Кон ***********");
            Console.WriteLine();
        }
    }
}