namespace RpgSaga
{
    public class ChupaChups : Player
    {
        public ChupaChups(int health, int strength, string name, Ability ability) : base(health, strength, name, ability)
        {
            PlayerClass = "Чупа-Чупс";
        }
    } 
}
