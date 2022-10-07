namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Entities; // эту штуку заставил создать семён, я не виновата, спасите

    public class Program
    {
        public static void Main()
        {
            Pet gaf = new Cat("Гаф", "чёрный", 5);
            Pet rex = new Dog("Рэкс", "черный", 6);
            Pet kesha = new Bird("Кеша", "зелёный", 2);

            var petList = new List<Pet>
            {
                gaf,
                rex,
                kesha,
            };

            foreach (var pet in petList)
            {
                Console.WriteLine(pet.GetInfo());
            }
        }
    }
}
