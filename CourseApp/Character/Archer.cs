namespace CourseApp
{
    using System;

    public class Archer : GameCharacter
    {
        public Archer(int health, int damage)
            : base(health, damage)
        {
            Skill = "Удар Грома";
            Weapon = "Лук";
        }

        public override string GetSkill()
        {
            return $"Лучник использует - {Skill}!!!";
        }

        public override string ToString()
        {
            return $"Archer (Health = {Health}, Damage = {Damage}, Skill = {Skill}, Weapon = {Weapon}.)";
        }
    }
}