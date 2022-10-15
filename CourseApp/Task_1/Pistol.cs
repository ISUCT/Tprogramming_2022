namespace CourseApp.Task_1
{
    using System;

    public class Pistol : Weapon
    {
        public Pistol(string shType, string name, int max)
        {
            WeaponType = "pistol";
            ShootingType = shType;
            Name = name;
            MaxAmmo = max;
        }

        public Pistol()
        {
            WeaponType = "pistol";
            ShootingType = "semi-auto";
            Name = "beretta92";
            MaxAmmo = 15;
        }

        public override void Info()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You have one {ShootingType} {WeaponType} : {Name}");
            Console.ResetColor();
        }

        public override void Shoot()
        {
            if (CurrentAmmo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RELOAD IMMEDIATELY!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("BANG!");
                Console.ResetColor();
                CurrentAmmo--;
            }
        }

        public override void Reload()
        {
            CurrentAmmo = MaxAmmo;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your pistol reloaded!");
            Console.ResetColor();
        }
    }
}