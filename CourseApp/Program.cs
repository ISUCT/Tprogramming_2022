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
            // def.Display();
            var ssj = new Copter() { Name = "SSJ100", Speed = 800, Diagonal = 8.2 };
            // ssj.Display();
            // ssj.Camera();
            var airbus = new Plane("Airbus", -1, 9500);
            // airbus.Display();
            // airbus.Land();
            // Console.WriteLine("----------------");
            var pt300 = new Copter("ПТ300", 800, 5000);
            // pt300.Display();
            var vw = new Car("VW Polo", 140);
            // vw.Display();
            // Console.WriteLine(def.ToString());
            // Console.WriteLine(ssj);
            // Console.WriteLine(airbus.ToString());

            var transport = new List<Vehicle> () {def, ssj, airbus, pt300, vw};
            foreach (var Vehicle in transport)
            {
                Console.WriteLine(Vehicle.Display());
            }
        }
    }
}