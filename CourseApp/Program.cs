namespace CourseApp.Task_one
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Country one = new Country();
            Country two = new Country("Brazil", 121321, 3213);
            one.Info();
            two.Info();
            one.ChangeArea();
            two.Population = 500;
            two.Population = -500;
            one.Info();
        }
    }
}
