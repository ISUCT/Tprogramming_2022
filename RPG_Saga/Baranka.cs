namespace RpgSaga
{
    public class Baranka : Player, PenetratingArrows
    {
        private bool _abilityIsUsed;
        public Baranka(int health, int strength, string name) : base(health, strength, name)
        {
            _abilityIsUsed = false;
            PlayerClass = "Баранка";
        }

        public override void UseAbility(Player enemy)
        {
            if (_abilityIsUsed)
            {
                Attack(enemy);
                return;
            }

            DoPenetration(enemy);
        }

        public void DoPenetration(Player enemy)
        {
            System.Console.WriteLine($"({PlayerClass}) {Name} поджигает {enemy.Name}");
            _abilityIsUsed = true;
            enemy.Burn();
        }
    } 
}
