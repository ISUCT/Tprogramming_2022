namespace RpgSaga
{
    public class ChupaChups : Player, KickBoxing
    {
        public ChupaChups(int health, int strength, string name) : base(health, strength, name)
        {
            PlayerClass = "Чупа-Чупс";
        }

        public override void UseAbility(Player enemy)
        {
            DoKickBox(enemy);
        }

        public void DoKickBox(Player enemy)
        {
            int damage = Strength + (int)(Strength * 0.3);
            System.Console.WriteLine($"{Name} демонстрирует мастерство кикбоксинга {enemy.Name} и наносит {damage} единиц урона");
            enemy.GetDamage(damage);
        }
    } 
}
