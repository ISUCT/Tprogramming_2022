namespace RpgSaga
{
    public class Wheelchair : Player
    {
        public Wheelchair(int health, int strength, string name) : base(health, strength, name)
        {
            PlayerClass = "Инвалидное кресло";
        }
    }
}
