namespace CourseApp
{
    using System;

    public class Mage : GameCharacter
    {
        public Mage(int health, int damage)
            : base(health, damage)
        {
            Skill_One = "Огненный шар";
            Skill_Two = "Ледянное копьё";
            Skill_Three = "Магический щит";
            Ultimate = "Созвучия пустоты";
            Weapon = "Магический посох";
        }

        public string GetUltimate()
        {
            return $"Вы используете ультимейт {Ultimate} !!!!";
        }

        public override void UseUltimate()
        {
            Console.WriteLine(GetUltimate());
        }

        public override string ToString()
        {
            return $"Archer (Health = {Health} Damage = {Damage} Skill_One = {Skill_One} Skill_Two = {Skill_Two} Skill_Three = {Skill_Three} Ultimate = {Ultimate}";
        }
    }
}
