namespace CourseApp
{
    using System;

    public class GameCharacter
    {
       private string characterClass;

       private float characterLevel;

       private string characterWeapon;

       private int characterDamage;

       public GameCharacter(string characterClass, float characterLevel, int characterDamage)
        {
            CharacterLevel = characterLevel;
            CharacterClass = characterClass;
            CharacterDamage = characterDamage;
        }

       public GameCharacter(string characterClass, float characterLevel)
        {
            CharacterLevel = characterLevel;
            CharacterClass = characterClass;
        }

       public string CharacterClass
        {
            get
            {
                return characterClass;
            }

            set
            {
                this.characterClass = value;
            }
        }

       public float CharacterLevel
        {
            get
            {
                return characterLevel;
            }

            set
            {
                if (value > 0 && value <= 100)
                {
                    this.characterLevel = value;
                }
            }
        }

       public string CharacterWeapon
        {
            get
            {
                return characterWeapon;
            }

            set
            {
                this.characterWeapon = value;
            }
        }

       public int CharacterDamage
        {
            get
            {
                return characterDamage;
            }

            set
            {
                if (value >= 0 && value <= 15)
                {
                    this.characterDamage = value;
                }
            }
        }

       public void Show()
        {
            System.Console.WriteLine($"Ваш класс {CharacterClass}, ваш текущий уровень {CharacterLevel}");
        }

       public void Damage(double buff)
        {
            this.CharacterDamage = (int)(CharacterLevel * buff);
            System.Console.WriteLine($"Ваш уровень {CharacterLevel}, вы наложили бафф {buff}, теперь урон вашего персонажа равен {CharacterDamage}");
        }

       public void Weapon()
        {
            if (characterClass == "Маг")
            {
                CharacterWeapon = "Посох";
            }

            if (characterClass == "Лучник")
            {
                CharacterWeapon = "Лук и стрелы";
            }

            Console.WriteLine($"Ваш класс {CharacterClass}, вам выдаётся оружие {CharacterWeapon}");
        }
    }
}
