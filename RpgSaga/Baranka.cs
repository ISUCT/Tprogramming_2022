namespace RpgSaga
{
    public class Baranka : Player
    {
        public Baranka(int health, int strength, string name, Ability ability) : base(health, strength, name, ability)
        {
            PlayerClass = "Баранка";
        }
    } 
}
