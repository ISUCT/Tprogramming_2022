namespace CourseApp.Task_one
{
    using System;

    public class Country
    {
        private string name;

        private int population;

        private int square;

        public Country(string inName, int inPop, int inSquare)
        {
            Name = inName;
            Population = inPop;
            Square = inSquare;
        }

        public Country()
        {
            Name = "Russia";
            Population = 145478097;
            Square = 17125191;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Population
        {
            get
            {
                return population;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Incorrect value of population.");
                }
                else
                {
                    population = value;
                }
            }
        }

        public int Square
        {
            get
            {
                return square;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Incorrect value of area.");
                }
                else
                {
                    square = value;
                }
            }
        }

        public void Info()
        {
            Console.WriteLine($"The country of {Name} has a population of {Population} people and an area of {Square} km^2");
        }

        public void ChangePopulation()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 1) == 1)
            {
                int buffer = rnd.Next(1, 32768);
                population += buffer;
                Console.WriteLine($"{buffer} people were born. Now in the country {Population} people");
            }
            else
            {
                int buffer = rnd.Next(1, 32768);
                population -= buffer;
                Console.WriteLine($"{buffer} people were died. Now in the country {Population} people.");
            }
        }

        public void ChangeArea()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 1) == 1)
            {
                int buffer = rnd.Next(1, 10000);
                Square -= buffer;
                Console.WriteLine($"The area of the country has decreased by {buffer} km^2. Now the area of the country {Square}.");
            }
            else
            {
                int buffer = rnd.Next(1, 10000);
                Square += buffer;
                Console.WriteLine($"The area of the country has increased by {buffer} km^2. Now the area of the country {Square}.");
            }
        }
    }
}