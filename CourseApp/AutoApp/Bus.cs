namespace AutoApp
{
    public class Bus : Automobile
    {
        public Bus(string name)
            : base(name)
        {
        }

        public override string Display()
        {
            return "Автобус имеет 30 мест";
        }
    }
}
