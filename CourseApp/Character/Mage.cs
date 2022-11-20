namespace CourseApp
{
    using System;

    public class Mage : GameCharacter
    {
        public Mage(int health, int damage)
            : base(health, damage)
        {
            Skill = "Созвучия пустоты";
            Weapon = "Магический посох";
        }

        public override string GetSkill()
        {
            return $"Маг использует - {Skill}!!!";
        }

        public override string ToString()
        {
            return $"Mage (Health = {Health}, Damage = {Damage}, Skill = {Skill}, Weapon = {Weapon}.)";
        }
    }
}
