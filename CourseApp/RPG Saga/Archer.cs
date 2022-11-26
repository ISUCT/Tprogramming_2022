namespace CourseApp
{
    using System;
    using System.Numerics;
    using System.Xml.Linq;

    public class Archer : Player
    {
        public Archer(string name, double health, int strength)
        : base(name, health, strength)
        {
            Class_player = "Лучник";
            UltimateName = "Лук с огненными стрелами";
        }

        public override int Ultimate(Player player, Player rival)
        {
            UltimateDamage = 2;
            Logger.LoggerOutput($"{Class_player} {Name} воспользовался {Ultimate}!");
            return Strength += UltimateDamage;
        }

        public override string InfoOutput()
        {
            return $"Призвание: {Class_player} ; Имя: {Name} ; Здоровье: {Health} ; Сила: {Strength}";
        }
    }
}