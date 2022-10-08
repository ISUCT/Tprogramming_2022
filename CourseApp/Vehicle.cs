namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Vehicle
    {
        private int speed;

        public Vehicle()
        {
            Name = "Транспорт";
            Speed = 100;
        }

        public Vehicle(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public string Name { get; set; }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value > 0 && value <= 1000)
                {
                    speed = value;
                }
                else
                {
                    speed = 700;
                }
            }
        }

        public abstract void Display();
    }
}