namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Airplane plane = new Airplane(270, 800, "A320");
            plane.TakeOff();
            plane.Speed = 840;
            plane.Fly();
            plane.Speed = 249;
            plane.Landing();

            Airplane plane2 = new Airplane();
            plane2.TakeOff();
            plane2.Fly();
            plane2.Landing();
        }
    }
}
