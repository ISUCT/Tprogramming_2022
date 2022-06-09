namespace RpgSaga
{
    public class Baranka : Player, PenetratingArrows
    {
        public override string AbilityName { get; set; }
        public Baranka(int health, int strength, string name) : base(health, strength, name)
        {
            AbilityName = "Проникающие стрелы";
            PlayerClass = "Баранка";
        }

        public override void UseAbility(Player enemy)
        {
            if (!CanUseAbility)
            {
                Attack(enemy);
                return;
            }

            DoPenetration(enemy);
        }

        public void DoPenetration(Player enemy)
        {
            System.Console.WriteLine($"({PlayerClass}) {Name} стреляет подожёнными проникающими стрелами в {enemy.Name}");
            CanUseAbility = false;
            enemy.Burn();
        }
    } 
}
