namespace CourseApp.Class
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Hydroplane hydroplane = new Hydroplane(80, 90, "DHC-2 Beaver", 255);

            hydroplane.GetInfo();
            hydroplane.SpeedUp();
            hydroplane.SpeedUp();
            hydroplane.Movement();
            hydroplane.SpeedDown();
            Console.WriteLine($"Speed right now is {hydroplane.GetSpeed}");
            hydroplane.Braking();
            Console.WriteLine($"Speed right now is {hydroplane.GetSpeed}");
        }
    }
}
