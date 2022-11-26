namespace CourseApp
{
    public class Archer : Hero
    {
        public Archer(int health, int power, string name)
            : base(health, power, name)
        {
        }

        public override string AbilityDisplay()
        {
            return $"{Name} использует (Огненные стрелы)";
        }
    }
}
