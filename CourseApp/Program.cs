namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            GameCharacter archer = new Archer(100, 20);
            GameCharacter mage = new Mage(80, 25);

            var characterArray = new GameCharacter[] { archer, mage };

            foreach (var character in characterArray)
            {
                character.Character();
                character.CharacterSkills();
                character.UseUltimate();
                Console.WriteLine();
            }
        }
    }
}