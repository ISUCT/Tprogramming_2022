namespace CourseApp.Task_two
{
    using System;

    public class England : Country
    {
        public England()
        {
            Name = "England";
            Population = 55980000;
            Square = 130279;
        }

        public override void Info()
        {
            Console.WriteLine($"The country of England has a population of {Population} people and an area of {Square} km^2");
        }

        public override void ChangePopulation()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 1) == 1)
            {
                int buffer = rnd.Next(1, 32768);
                Population += buffer;
                Console.WriteLine($"{buffer} people were born. Now in the country {Population} people");
            }
            else
            {
                int buffer = rnd.Next(1, 32768);
                Population -= buffer;
                Console.WriteLine($"{buffer} people were died. Now in the country {Population} people.");
            }
        }

        public override void ChangeArea()
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
