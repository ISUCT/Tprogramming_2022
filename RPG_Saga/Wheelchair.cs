namespace RpgSaga
{
    public class Wheelchair : Player, Rocking
    {
        public override string AbilityName { get; set; }
        public Wheelchair(int health, int strength, string name) : base(health, strength, name)
        {
            AbilityName = "Качание";
            PlayerClass = "Инвалидное кресло";
        }

        public void DoRock(Player enemy)
        {
            //Здесь код 
        }
    }
}
