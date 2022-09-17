namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Pet cat = new Pet("Гав", "черный", 3);
            cat.Show();

            Pet dog = new Pet("Шарик", "рыжий", 9);
            dog.Show();
        }
    }
}
