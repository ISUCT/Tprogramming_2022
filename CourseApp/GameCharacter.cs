namespace CourseApp
{
    using System;

    public abstract class GameCharacter
    {
        private int health;
        private int damage;

        public GameCharacter(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value > 0)
                {
                    this.health = value;
                }
                else
                {
                    throw new Exception("Health below zero");
                }
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                if (value > 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new Exception("Damage below zero");
                }
            }
        }

        public string Skill { get; set; }

        public string Weapon { get; set; }

        public void DropWeapon()
        {
            Weapon = "Оружие потеряно";
        }

        public void UseUltimate()
        {
            Console.WriteLine(GetSkill());
        }

        public abstract string GetSkill();
    }
}
