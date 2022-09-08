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
                if (value > 0 && value < 100)
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
                if (value > 45 && value < 240)
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
                if (value > 0.3 && value < 300)
                {
                    this.weight = value;
                }
            }
        }

        public void Midlle_Age()
        {
            if (age < 18)
            {
                System.Console.WriteLine("Are you a child;");
            }
            else if (age == 18 || age < 45)
            {
                System.Console.WriteLine("You're a young man;");
            }
            else if (age >= 59)
            {
                System.Console.WriteLine("You're middle-aged;");
            }
            else if (age <= 100)
            {
                System.Console.WriteLine("You are an elderly man;");
            }
        }

        public void Average_Height()
        {
            if (height < 177)
            {
                System.Console.WriteLine("Your height is below average in Russia;");
            }
            else if (height >= 177)
            {
                System.Console.WriteLine("Your height is above average in Russia;");
            }
        }

        public void Average_Weight()
        {
            if (height < 80)
            {
                System.Console.WriteLine("Your weight is below average in Russia.");
            }
            else if (height > 80)
            {
                System.Console.WriteLine("Your weight is above average in Russia.");
            }
        }

        public void Show()
        {
            Console.WriteLine($"The person is {age} years old.");
            Console.WriteLine($"His weight is {weight} kg and height {height} cm.");
        }
    }
}
