namespace RpgSaga
{
    public class Wheelchair : Player
    {
        public Wheelchair(int health, int strength, string name, Ability ability) : base(health, strength, name, ability)
        {
            PlayerClass = "Инвалидное кресло";
        }
    }
}
