namespace CourseApp
{
    using System;

    public abstract class Human
    {
        private int age;
        private int height;
        private float weight;

        public Human(int age)
        {
            Age = age;
        }

        public Human(int age, int height, float weight)
        {
            Age = age;
            Height = height;
            Weight = weight;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0 && value <= 110)
                {
                    this.age = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 45 && value <= 240)
                {
                    this.height = value;
                }
            }
        }

        public float Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value >= 0.3 && value <= 300)
                {
                    this.weight = value;
                }
            }
        }

        public string Midlle_Age()
        {
            if (age > 0 && age < 18)
            {
                Console.WriteLine("Are you a child;");
                return "Are you a child;";
            }
            else if (age == 0)
            {
                Console.WriteLine("Input error in age;");
                return "Input error in age;";
            }
            else if (age >= 18 && age <= 44)
            {
                Console.WriteLine("You're a young person;");
                return "You're a young man;";
            }
            else if (age >= 45 && age <= 59)
            {
                Console.WriteLine("You're middle-aged;");
                return "You're middle-aged;";
            }
            else if (age >= 60 && age <= 74)
            {
                Console.WriteLine("You are an elderly man;");
                return "You are an elderly man;";
            }
            else if (age >= 75 && age <= 89)
            {
                Console.WriteLine("Are you an old man;");
                return "Are you an old man;";
            }
            else if (age >= 90)
            {
                Console.WriteLine("Are you a long-lived person;");
                return "Are you a long-lived person;";
            }

            return "Default";
        }

        public void Show()
        {
            Console.WriteLine("Based on the results of the entered data:");
        }

        public abstract string Average_Height();

        public abstract string Average_Weight();
    }
}