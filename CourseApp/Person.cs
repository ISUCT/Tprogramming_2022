namespace CourseApp
{
    using System;

    public class Person
    {
        private int age;
        private int height;
        private float weight;

        public Person(int age)
        {
            Age = age;
        }

        public Person(int age, int height, float weight)
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
                System.Console.WriteLine("Are you a child;");
                return "Are you a child;";
            }
            else if (age == 0)
            {
                System.Console.WriteLine("Input error in age;");
                return "Input error in age;";
            }
            else if (age >= 18 && age <= 44)
            {
                System.Console.WriteLine("You're a young man;");
                return "You're a young man;";
            }
            else if (age >= 45 && age <= 59)
            {
                System.Console.WriteLine("You're middle-aged;");
                return "You're middle-aged;";
            }
            else if (age >= 60 && age <= 74)
            {
                System.Console.WriteLine("You are an elderly man;");
                return "You are an elderly man;";
            }
            else if (age >= 75 && age <= 89)
            {
                System.Console.WriteLine("Are you an old man;");
                return "Are you an old man;";
            }
            else if (age >= 90)
            {
                System.Console.WriteLine("Are you a long-lived person;");
                return "Are you a long-lived person;";
            }

            return "Default";
        }

        public string Average_Height()
        {
            if (height >= 45 && height < 177)
            {
                System.Console.WriteLine("Your height is below average in Russia;");
                return "Your height is below average in Russia;";
            }
            else if (height >= 177 && height <= 240)
            {
                System.Console.WriteLine("Your height is above average in Russia;");
                return "Your height is above average in Russia;";
            }
            else if (height == 0)
            {
                System.Console.WriteLine("Input error in height;");
                return "Input error in height;";
            }

            return "Default";
        }

        public string Average_Weight()
        {
            if (weight >= 0.3 && weight <= 80)
            {
                System.Console.WriteLine("Your weight is below average in Russia.");
                return "Your weight is below average in Russia.";
            }
            else if (weight > 80 && weight <= 300)
            {
                System.Console.WriteLine("Your weight is above average in Russia.");
                return "Your weight is above average in Russia.";
            }
            else if (weight == 0)
            {
                System.Console.WriteLine("Input error in weight;");
                return "Input error in weight;";
            }

            return "Default";
        }

        public void Show()
        {
            Console.WriteLine($"The person is {age} years old.");
            Console.WriteLine($"His weight is {weight} kg and height {height} cm.");
        }
    }
}