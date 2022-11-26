namespace CourseApp
{
    public interface IPlayer
    {
        string Name { get; set; }

        double Health { get; set; }

        int Strength { get; set; }
    }
}