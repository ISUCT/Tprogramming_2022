namespace CourseApp
{
    using System;
    using CourseApp.RPGSaga;

    public abstract class Transport
    {
        private int _speed;

        public Transport()
            : this(0, 0, 0, 0, 0, "No_name")
        {
        }

        public Transport(double length, double height, int weight, int power, int maxSpeed, string model)
        {
            Length = length;
            Weight = weight;
            Power = power;
            Height = height;
            MaxSpeed = maxSpeed;
            Model = model;
        }

        public string Model { get; set; }

        public int Power { get; }

        public double Length { get; }

        public int Weight { get; }

        public double Height { get; }

        public int MaxSpeed { get; }

        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                try
                {
                    if (value > MaxSpeed || value < 0)
                    {
                        throw new Exception($"speed is too large or too little for {Model}");
                    }
                    else
                    {
                        _speed = value;
                    }
                }
                catch (Exception e)
                {
                    new ArgumentException($"Error: {e.Message}");
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        public abstract ActionTypes Movement();

        public string GetInfo()
        {
            return @$"Info for {Model}
Weight: {Weight} kg
Length: {Length} m 
Height: {Height} m
Power: {Power} horsepower
Max Speed: {MaxSpeed} km\h";
        }
    }
}
