namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Program
    {
        public static void Main(string[] args)
        {
            var MiniWorld = new MiniWorld("- Мини мир");
            var user = new UserInterface();
            user.Have(MiniWorld);
        }
    }
}