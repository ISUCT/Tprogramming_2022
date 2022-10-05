namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Pet cat = new FourLeggedAnimal("Гав", "черный", 3);
            cat.Show1();

            Pet dog = new FourLeggedAnimal("Шарик", "рыжий", 9);
            dog.Show2();

            Pet parrot = new Bird("Кеша", "красный", 1);
            parrot.Show1();
        }
    }
}
