namespace CourseApp
{
    using System;
    using AutoApp;

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

            Automobile minibus = new Minibus("Маршрутка");
            Automobile bus = new Bus("Автобус");
            Automobile trolleybus = new Trolleybus("Троллейбус");
            Console.WriteLine("--------------------------");
            Console.WriteLine(minibus.Display());
            minibus.Move();
            Console.WriteLine(bus.Display());
            bus.Move();
            Console.WriteLine(trolleybus.Display());
            trolleybus.Move();
        }
    }
}
