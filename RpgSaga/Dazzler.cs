namespace RpgSaga
{
    public class Dazzler : Player
    {
        public Dazzler(int health, int strength, string name, Ability ability) : base(health, strength, name, ability)
        {
            PlayerClass = "Колдун-ослепитель";
        }
    }
}
