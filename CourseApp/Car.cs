namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car : Vehicle
    {
        public Car()
        {
            Name = "Lada";
            Speed = 100;
        }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public override void Display()
        {
            Console.WriteLine($"Автомобиль {Name}, скорость {Speed}");
        }
    }
}