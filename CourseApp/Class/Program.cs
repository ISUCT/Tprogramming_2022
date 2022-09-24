namespace CourseApp.Class
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var plane = new Plane("DHC-2 Beaver", 255, 450, 9.22, 2.74, 1361);

            plane.GetInfo();
            plane.Takeoff();
            plane.Speed = 250;
            plane.Direction = "Belarus";
            plane.Movement();
            plane.Landing();
            plane.Speed = 300;
        }
    }
}
