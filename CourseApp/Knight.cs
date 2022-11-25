namespace CourseApp
{
    public class Knight : Hero
    {
        public Knight(int health, int power, string name)
            : base(health, power, name)
        {
        }

        public override string AbilityDisplay()
        {
            Power = Power + 30;
            return $"{Name} использует (Удар возмездия) и наносит урон {Power}";
        }
    }
}
