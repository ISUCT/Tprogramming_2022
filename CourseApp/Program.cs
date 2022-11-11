namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            var def = new Plane() { Speed = 1000, Height = 11000 };
            var ssj = new Copter() { Name = "SSJ100", Speed = 800, Diagonal = 8.2 };
            var airbus = new Plane("Airbus", -1, 9500);
            var pt300 = new Copter("ПТ300", 800, 5000);
            var vw = new Car("VW Polo", 140);

            var transport = new List<Vehicle>() { def, ssj, airbus, pt300, vw };
            foreach (var vehicle in transport)
            {
                Console.WriteLine(vehicle.Display());
            }
        }
    }
}