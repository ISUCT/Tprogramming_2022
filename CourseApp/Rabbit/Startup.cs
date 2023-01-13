namespace CourseApp
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit(5, "Gray", "male");
            rabbit.SwitchName("Stepan");
            rabbit.GetInfo();
            rabbit.Move();
            rabbit.Eat("carrot");
        }
    }
}
