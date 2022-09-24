namespace CourseApp
{
    public abstract class Transport
    {
        public Transport()
            : this(0, 0, 0, 0, 0)
        {
        }

        public Transport(double length, double height, int weight, int power, int maxSpeed)
        {
            Length = length;
            Weight = weight;
            Power = power;
            Height = height;
            MaxSpeed = maxSpeed;
        }

        public int Power { get; }

        public double Length { get; }

        public int Weight { get; }

        public double Height { get; }

        public int MaxSpeed { get; }

        public abstract string Movement();

        public virtual string GetInfo()
        {
            string info = @$"Info for transport
Weight: {Weight}kg
Length: {Length}m 
Height: {Height}m
Power: {Power}horsepower
Max Speed: {MaxSpeed}km\h";

            return info;
        }
    }
}
