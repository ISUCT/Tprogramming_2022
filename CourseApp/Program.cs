namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getting started");
            GameCharacter character1 = new GameCharacter("Маг", 56);
            character1.Show();
            character1.Damage(0.25);
            character1.Weapon();

            GameCharacter character2 = new GameCharacter("Лучник", 45);
            character2.Show();
            character2.Damage(0.25);
            character2.Weapon();
        }
    }
}