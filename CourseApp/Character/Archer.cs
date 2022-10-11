namespace CourseApp
{
    using System;

    public class Archer : GameCharacter
    {
        public Archer(int health, int damage)
            : base(health, damage)
        {
            Skill_One = "Быстрый выстрел";
            Skill_Two = "Морозная стрела";
            Skill_Three = "Крылья защиты";
            Ultimate = "Удар Грома";
            Weapon = "Лук";
        }

        public string GetUltimate()
        {
            return $"Вы используете ультимейт {Ultimate}!!!!";
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