namespace RpgSaga
{
    public class Kickboxer : Player
    {
        public Kickboxer(int health, int strength, string name, Ability ability) : base(health, strength, name, ability)
        {
            PlayerClass = "Кикбоксёр";
        }
    } 
}
