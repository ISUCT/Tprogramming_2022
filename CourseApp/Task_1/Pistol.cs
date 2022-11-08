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

        public override string Info()
        {
            return $"You have one {ShootingType} {WeaponType} : {Name}";
        }

        public override bool Shoot()
        {
            if (CurrentAmmo == 0)
            {
                return false;
            }
            else
            {
                CurrentAmmo--;
                return true;
            }
        }

        public override bool Reload()
        {
            CurrentAmmo = MaxAmmo;
            return true;
        }
    }
}