namespace CourseApp.Class
{
    public class Program
    {
        public static void Main()
        {
            Hydroplane hydroplane = new Hydroplane(450, 9, 1361, 80, 90, 8, 2, "DHC-2 Beaver", 255);

            hydroplane.GetInfo();
            hydroplane.SetDirection();
            hydroplane.TakeSpeed();
            hydroplane.SpeedUp();
            hydroplane.TakeSpeed();
            hydroplane.SpeedUp();
            hydroplane.Movement();
            hydroplane.SpeedDown();
            hydroplane.TakeSpeed();
            hydroplane.Braking();
            hydroplane.TakeSpeed();
        }
    }
}
