namespace CourseApp.Task_two
{
    using System;

    public abstract class Country
    {
        private string name;

        private int population;

        private int square;

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

        public abstract void Info();

        public abstract void ChangePopulation();

        public abstract void ChangeArea();
    }
}