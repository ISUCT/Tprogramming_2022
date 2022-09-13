namespace CourseApp.Class
{
    using System;

    public class Hydroplane : Plane, ILanding, ITakeoff
    {
        private int lengthFloat;
        private int speed;
        private int power;
        private int length;
        private int weight;
        private int landingSpeed;
        private int takeoffSpeed;
        private int numberWings;
        private string direction;
        private string model;
        private int maxSpeed;

        public Hydroplane(int power, int length, int weight, int landingSpeed, int takeoffSpeed, int lengthFloat, int numberWings, string model, int maxSpeed)
            : base(numberWings)
        {
            this.power = power;
            this.length = length;
            this.weight = weight;
            this.landingSpeed = landingSpeed;
            this.takeoffSpeed = takeoffSpeed;
            this.lengthFloat = lengthFloat;
            this.numberWings = numberWings;
            this.model = model;
            this.maxSpeed = maxSpeed;
            direction = string.Empty;
            speed = 0;
        }

        public override void GetInfo()
            => Console.WriteLine($"Model: {model} \nPower: {power}horsepower \nLength: {length}m \nWeight: {weight}kg \nLanding speed: {landingSpeed}km/h \nTakeoff speed: {takeoffSpeed}km/h \nMax speed: {maxSpeed}km/h");

        public override void Movement() => Console.WriteLine($"Самолёт движется со скоростью {speed} км/ч, в направлении: {direction}");

        public override void TakeSpeed() => Console.WriteLine($"Speed right now: {speed}km/h");

        public int GetSpeed() => speed;

        public void SpeedDown() => speed = landingSpeed;

        public void Braking() => speed = 0;

        public void SetDirection()
        {
            Console.Write("Введите направление, курс полёта: ");
            direction = Console.ReadLine();
        }

        public int SpeedUp() => speed == 0 ? speed = takeoffSpeed : speed = maxSpeed;
    }
}
