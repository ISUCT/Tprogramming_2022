namespace CourseApp.Class
{
    using System;

    public class Plane : Transport, ILanding
    {
        private string model;
        private int speed;
        private string direction;

        public Plane()
            : this("No_name", 0, 0, 0, 0, 0)
        {
        }

        public Plane(string model, int maxSpeed, int power, double length, double height, int weight)
            : base(length, height, weight, power, maxSpeed)
        {
            this.model = model;
            direction = "some direction";
        }

        public string Exc { get; set; }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                try
                {
                    if (value > MaxSpeed || value < 0)
                    {
                        throw new Exception($"speed is too large or too little for {model}");
                    }
                    else
                    {
                        speed = value;
                    }
                }
                catch (Exception e)
                {
                    Exc = $"Error: {e.Message}";
                    Console.WriteLine(Exc);
                }
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }

            set
            {
                direction = value;
            }
        }

        public string Takeoff()
        {
            string takeoff = $"{model} taking off";
            Console.WriteLine(takeoff);
            return takeoff;
        }

        public string Landing()
        {
            string landing = $"{model} going to land";
            Console.WriteLine(landing);
            return landing;
        }

        public override string GetInfo()
        {
            string info = @$"Info for Plane {model}
Weight: {Weight}kg
Length: {Length}m 
Height: {Height}m
Power: {Power} horsepower
Max Speed: {MaxSpeed}km\h";

            Console.WriteLine(info);
            return info;
        }

        public override string Movement()
        {
            string move = $"{model} is moving at a speed {Speed}km/h in the {Direction}";
            Console.WriteLine(move);
            return move;
        }
    }
}
