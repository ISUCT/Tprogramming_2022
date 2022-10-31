namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Airplane passenger = new Passenger(270, 800, "A320");
            Airplane fighter = new Fighter(270, 800, "A320");

            var planeArray = new Airplane[] { passenger, fighter };

            foreach (var plane in planeArray)
            {
                var tostring = plane.ToString();
                Console.WriteLine($"{tostring}");
                Console.WriteLine(plane.MyRole());
                plane.TakeOff();
                plane.Speed = 840;
                plane.Fly();
                plane.Speed = 249;
                plane.Landing();
                Console.WriteLine();
            }
        }
    }
}
