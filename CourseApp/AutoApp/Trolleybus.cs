namespace AutoApp
{
    public class Trolleybus : Automobile
    {
        public Trolleybus(string name)
            : base(name)
        {
        }

        public override string Display()
        {
            return "Троллейбус имеет 42 места";
        }
    }
}
