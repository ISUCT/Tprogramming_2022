namespace CourseApp
{
    public class Minibus : Automobile
    {
        public Minibus(string name)
            : base(name)
        {
        }

        public override string Display()
        {
            return "Маршрутка имеет 20 мест";
        }
    }
}
