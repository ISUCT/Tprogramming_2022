namespace CourseApp
{
    using System;
    using System.Numerics;
    using System.Xml.Linq;

    public class Cavalier : Player
    {
        public Cavalier(string name, double health, int strength)
        : base(name, health, strength)
        {
            Class_player = "Рыцарь";
            UltimateName = "Супер острый меч";
        }

        public override int Ultimate(Player player, Player rival)
        {
            Logger.LoggerOutput($"{Class_player} {Name} воспользовался {Ultimate}!");
            return Strength = (int)(Strength * 1.3);
        }

        public override string InfoOutput()
        {
            return $"Призвание: {Class_player} ; Имя: {Name} ; Здоровье: {Health} ; Сила: {Strength}";
        }
    }
}