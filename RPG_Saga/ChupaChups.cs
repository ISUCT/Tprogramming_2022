namespace RpgSaga
{
    public class ChupaChups : Player, KickBoxing
    {
        public override string AbilityName { get; set; }
        public ChupaChups(int health, int strength, string name) : base(health, strength, name)
        {
            AbilityName = "Кикбоксинг";
            PlayerClass = "Чупа-Чупс";
        }

        public override void UseAbility(Player enemy)
        {
            DoKickBox(enemy);
        }

        public void DoKickBox(Player enemy)
        {
            int subDamage = (int)(Strength * 0.3);
            Strength += subDamage;
            System.Console.WriteLine($"({PlayerClass}) {Name} демонстрирует мастерство кикбоксинга противнику {enemy.Name} и наносит {Strength} единиц урона");
            enemy.GetDamage(Strength);

            Strength -= subDamage;
        }
    } 
}
