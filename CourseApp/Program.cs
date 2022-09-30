namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Phone phone1 = new Phone("iPhone", -7);
            // phone1.Show();
            // phone1.Diagonal = 7;
            // phone1.Show();
            // phone1.Diagonal = -16;
            // phone1.Show();

            // Phone tablet = new Phone("Android", 6);
            // tablet.Diagonal = 6;
            // tablet.Show();
            // tablet.Diagonal = -10;
            // tablet.Show();
            // tablet.Diagonal = 8;
            // tablet.Show();
            // Console.WriteLine("Hello World");

            var def = new Plane() { Speed = 1000, Height = 11000 };
            def.Display();
            var ssj = new Copter() { Name = "SSJ100", Speed = 800, Diagonal = 8.2 };
            ssj.Display();
            ssj.Camera();
            var airbus = new Plane( "Airbus", -1, 9500 );
            airbus.Display();
            airbus.Land();
        }
    }
}