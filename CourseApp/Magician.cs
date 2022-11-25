namespace CourseApp
{
    public class Magician : Hero
    {
        public Magician(int health, int power, string name)
            : base(health, power, name)
        {
        }

        public override string AbilityDisplay()
        {
            return $"{Name} использует (Заворожение) и противник пропускает ход";
        }
    }
}
