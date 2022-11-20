namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            GameCharacter archer = new Archer(100, 20);
            GameCharacter mage = new Mage(80, 25);

            var characterArray = new List<GameCharacter>() { archer, mage };

            foreach (var character in characterArray)
            {
                Console.WriteLine(character.ToString());
                character.UseUltimate();
                character.DropWeapon();
                Console.WriteLine(character.ToString());
                Console.WriteLine();
            }
        }
    }
}