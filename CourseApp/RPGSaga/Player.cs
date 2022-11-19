namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Player
    {
        private double maxhealth;
        /* private double health; */
        private double power;

        public Player()
        {
            Name = "<Безымянный>";
            Maxhealth = 100;
            Power = 1;
        }

        public Player(string name, double maxhealth, double power)
        {
            Name = name;
            Maxhealth = maxhealth;
            Power = power;
        }

        public string Name { get; set; }

        public double Maxhealth
        {
            get
            {
                return maxhealth;
            }

            set
            {
                if (value > 0 && value <= 100)
                {
                    maxhealth = value;
                }
                else
                {
                    maxhealth = 50;
                }
            }
        }

        public double Health
        {
            get
            {
                return maxhealth;
            }
        }

        public double Power
        {
            get
            {
                return power;
            }

            set
            {
                if (value > 0 && value <= 10)
                {
                    power = value;
                }
                else
                {
                    power = 5;
                }
            }
        }

        public void Greetings()
        {
            Console.WriteLine($"Игрок {Name} (здоровье {Maxhealth}, атака {Power}) готов к бою!");
        }

        public double DealDamage()
        {
            Console.WriteLine($"{Name} наносит {Power} урона");
            return Power;
        }

/*        public double GetDamage()
        {
            Health = Health - damage
        } */
    }
}