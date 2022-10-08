namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            Archer archer = new ("Azir", "Black Onion", 79);
            TheMagian magian = new ("Rise", "CristalStaff", 85);
            Guardian guard = new ("Leo", "zweihender", 95);
            
            var characterList = new List<Character>
            {
                archer,
                magian,
                guard,
            };

            foreach (var Character in characterList)
            {
                Character.Print();
                Console.WriteLine(Character.Guild());
                Console.WriteLine(Character.GetInfo());
            }
        }
    }
}
