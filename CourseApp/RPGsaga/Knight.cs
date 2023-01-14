namespace RPGsagaApp
{
    public class Knight : Hero
    {
        public Knight(int health, int power, string name, string ability)
            : base(health, power, name, ability)
        {
        }

        public override string AbilityDisplay()
        {
            Power = Power + 30;
            return $"Рыцарь {Name} использует {Ability} и наносит урон {Power} противнику";
        }
    }
}
