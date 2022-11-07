namespace CourseApp.Class
{
    public class Program
    {
        public static void Main()
        {
            Transport plane = new Plane(9.22, 2.74, 1361, 450, 255, "DHC-2 Beaver");
            if (plane is Plane beaver)
            {
                System.Console.WriteLine(beaver.GetInfo());
                System.Console.WriteLine(beaver.ToString());
                beaver.Takeoff();
                beaver.Speed = 250;
                beaver.Direction = "Belarus";
                beaver.Movement();
                beaver.Landing();
                beaver.Speed = 300;
                System.Console.WriteLine(beaver.Speed);
            }

            Transport auto = new Auto();
            if (auto is Auto audi)
            {
            }

            Transport[] transports = new Transport[2] { plane, auto };

            if (transports[0] is Plane plane1)
            {
                plane1.Movement();
            }

            if (transports[1] is Auto auto1)
            {
                auto1.Movement();
            }
        }
    }
}
