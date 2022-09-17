using System;

namespace CourseClass
{
    public class Auto
    {
        private int speed;
        public Auto() : this("Car", 45, 80)
        { }
        public Auto (string name, int speed, int weight)
        {
            Name = name;
            Speed = speed;
            LoadingCapacity = weight;

        }

        public string Name { get; set; }

        public int LoadingCapacity { get; set; }

        public void Ride()
        {
            Console.WriteLine($"Поехал автомобиль {Speed}");
        }

        public void Stop()
        {
            Console.WriteLine("Остановился автомобиль");
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value > 0)
                {
                    this.speed = value;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"Название: {Name}  Скорость: {speed}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Auto cr = new Auto();
            cr.Print();

            Auto car = new Auto("Limousine", 35, 70);
            string autoName = car.Name;
            int autoSpeed = car.Speed;
            Console.WriteLine($"Название: {autoName}  Скорость: {autoSpeed}");

            car.Name = "LadaSedan";
            car.Ride();
            car.Speed = 120;
            car.Print();
            car.Stop();
        }
    }
}
