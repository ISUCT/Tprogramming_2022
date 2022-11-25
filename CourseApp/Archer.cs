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
            return $"{Name} использует (Огненные стрелы) и противник теряет за каждый ход 2 единицы жизни";
        }
    }
}
