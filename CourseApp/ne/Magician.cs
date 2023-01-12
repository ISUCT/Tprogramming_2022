namespace CourseApp
{
    using System;

    public class Magician : Player
    {
        public Magician(string name, double health, int strength)
        : base(name, health, strength)
        {
            Class_player = "Волшебник";
            UltimateName = "Магические колбочки";
        }

        public override int Ultimate(Player player, Player rival)
        {
            if (player.Impact)
            {
                player.Inactive = 1;
                rival.Inactive = 2;
            }
            else if (rival.Impact)
            {
                player.Inactive = 2;
                rival.Inactive = 1;
            }

            Logger.LoggerOutput($"{Class_player} {Name} воспользовался {Ultimate}!");
            return 0;
        }

        public override string InfoOutput()
        {
            return $"Призвание: {Class_player} ; Имя: {Name} ; Здоровье: {Health} ; Сила: {Strength}";
        }
    }
}