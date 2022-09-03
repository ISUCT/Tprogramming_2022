namespace RpgSaga
{
    public class Archer : Player
    {
        public Archer(int health, int strength, string name, Ability ability) : base(health, strength, name, ability)
        {
            PlayerClass = "Лучник";
        }
    } 
}
