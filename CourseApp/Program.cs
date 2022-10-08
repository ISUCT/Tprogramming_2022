namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var def = new Plane() { Speed = 1000, Height = 11000 };
            def.Display();
            var ssj = new Copter() { Name = "SSJ100", Speed = 800, Diagonal = 8.2 };
            ssj.Display();
            ssj.Camera();
            var airbus = new Plane("Airbus", -1, 9500);
            airbus.Display();
            airbus.Land();
            Console.WriteLine("----------------");
            var pt300 = new Copter("ПТ300", 800, 5000);
            pt300.Display();
            Console.WriteLine(def.ToString());
            Console.WriteLine(ssj);
            Console.WriteLine(airbus.ToString());
        }
    }
}