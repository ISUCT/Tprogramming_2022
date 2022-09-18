namespace CourseApp.Class
{
    using System;

    public class Hydroplane : Plane, ILanding, ITakeoff
    {
        private int landingSpeed;
        private string info;
        private int takeoffSpeed;
        private string model;
        private int maxSpeed;
        private int speed;
        private string direction;

        public Hydroplane(int landingSpeed, int takeoffSpeed, string model, int maxSpeed)
        {
            this.landingSpeed = landingSpeed;
            this.takeoffSpeed = takeoffSpeed;
            this.model = model;
            this.maxSpeed = maxSpeed;
        }

        public override int GetSpeed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
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

        public override string GetInfo()
        {
            info = @$"Model: {model}
Landing speed: {landingSpeed}km/h 
Takeoff speed: {takeoffSpeed}km/h 
Max speed: {maxSpeed}km/h";
            Console.WriteLine(info);
            return info;
        }

        public override void Movement()
        {
            Console.Write("Enter the direction of the plane: ");
            Direction = Console.ReadLine();
            Console.WriteLine($"The plane is moving at a speed {GetSpeed}km/h in the direction: {Direction}");
        }

        public void SpeedDown()
        {
            GetSpeed = landingSpeed;
            Console.WriteLine("The plane is landing");
        }

        public void Braking()
        {
            GetSpeed = 0;
            Console.WriteLine("The plane has landed");
        }

        public void SpeedUp()
        {
            if (GetSpeed == 0)
            {
                Console.WriteLine("The Plane is taking off");
                speed = landingSpeed;
            }
            else
            {
                speed = maxSpeed;
            }
        }
    }
}
