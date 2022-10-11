namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var archer = new Archer(100, 20);
            Console.WriteLine("Вы Лучник");
            archer.CharacterHealth();
            archer.CharacterDamage();
            archer.CharacterSkills();
            archer.CharacterWeapons();
            archer.ToString();
            archer.UseUltimate();
            Console.WriteLine(" ");
            var mage = new Mage(80, 25);
            Console.WriteLine("Вы Маг");
            mage.CharacterHealth();
            mage.CharacterDamage();
            mage.CharacterSkills();
            mage.CharacterWeapons();
            mage.ToString();
            mage.UseUltimate();
        }
    }
}