namespace CourseApp
{
    using System;

    public abstract class GameCharacter
    {
        private string skillone;
        private string skilltwo;
        private string skillthree;
        private string ultimate;
        private string weapon;
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
                this.health = value;
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
                this.damage = value;
            }
        }

        public string Skill_One
        {
            get
            {
                return this.skillone;
            }

            set
            {
                this.skillone = value;
            }
        }

        public string Skill_Two
        {
            get
            {
                return this.skilltwo;
            }

            set
            {
                this.skilltwo = value;
            }
        }

        public string Skill_Three
        {
            get
            {
                return this.skillthree;
            }

            set
            {
                this.skillthree = value;
            }
        }

        public string Ultimate
        {
            get
            {
                return this.ultimate;
            }

            set
            {
                this.ultimate = value;
            }
        }

        public string Weapon
        {
            get
            {
                return this.weapon;
            }

            set
            {
                this.weapon = value;
            }
        }

        public void CharacterSkills()
        {
            Console.WriteLine($"Первый скилл вашего класса это {Skill_One}");
            Console.WriteLine($"Второй скилл вашего класса это {Skill_Two}");
            Console.WriteLine($"Третий скилл вашего класса это {Skill_Three}");
            Console.WriteLine($"Ульта вашего класса это {Ultimate}");
        }

        public string GetCharacterWeapons()
        {
            string result = $"Ваше оружие - это {Weapon}";
            return result;
        }

        public string GetCharacterHealth()
        {
            string result = $"Ваше здоровье - {Health}";
            return result;
        }

        public string GetCharacterDamage()
        {
            string result = $"Ваш урон - {Damage}";
            return result;
        }

        public void Character()
        {
            Console.WriteLine(GetCharacterWeapons());
            Console.WriteLine(GetCharacterHealth());
            Console.WriteLine(GetCharacterDamage());
        }

        public abstract void UseUltimate();
    }
}
