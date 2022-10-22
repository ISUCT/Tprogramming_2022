namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using Character;

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

            foreach (var character in characterList)
            {
                character.Print();
                Console.WriteLine(character.Guild());
                Console.WriteLine(character.GetInfo());
                Console.WriteLine(character.ToString());
            }
        }
    }
}
